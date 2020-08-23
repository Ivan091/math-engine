using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public abstract class BinSign : Sign
    {
        public abstract double Calculate(double lNum, double rNum);

        public override abstract Lexem CreateSame(Match match);

        public override void RPNCalculate(Stack<Lexem> lexems)
        {
            var rNum = lexems.Peek() as Number;
            lexems.Pop();

            var lNum = lexems.Peek() as Number;

            lNum.Value = this.Calculate(lNum.Value, rNum.Value);
        }
    }
}
