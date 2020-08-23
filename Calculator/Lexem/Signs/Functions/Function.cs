using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public abstract class Function : Sign
    {
        public override Priority Priority => Priority.Function;

        public abstract override Lexem CreateSame(Match match);

        public abstract double Compute(double arg);

        public override void RPNCalculate(Stack<IRPNCalculatable> lexems)
        {
            var arg = lexems.Peek() as Number;
            arg.Value = this.Compute(arg.Value);
        }
    }
}
