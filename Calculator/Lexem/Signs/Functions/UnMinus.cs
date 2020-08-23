using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    class UnMinus : Function
    {
        public override double Compute(double arg)
        {
            return -arg;
        }

        public override Lexem CreateSame(Match match)
        {
            return new UnMinus();
        }

        public override void RPNCalculate(Stack<IRPNCalculatable> lexems)
        {
            base.RPNCalculate(lexems);

            var num = lexems.Pop();

            if (lexems.TryPeek(out var result))
            {
                if (result is Number)
                {
                    lexems.Push(num);

                    new Plus().RPNCalculate(lexems);
                    return;
                }

            } 
                lexems.Push(num);

        }
    }
}
