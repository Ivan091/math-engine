using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public abstract class BinSign : Sign
    {
        public abstract double Compute(double lArg, double rArg);

        public override abstract Lexem CreateSame(Match match);

        public override void RPNCalculate(Stack<IRPNCalculatable> lexems)
        {
            var rArg = lexems.Peek() as Number;
            lexems.Pop();

            var lArg = lexems.Peek() as Number;

            lArg.Value = this.Compute(lArg.Value, rArg.Value);
        }
    }
}
