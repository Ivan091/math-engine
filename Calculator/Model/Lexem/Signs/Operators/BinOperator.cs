using System.Collections.Generic;

namespace Calculator
{
    internal abstract class BinOperator : Sign
    {
        public override void RPNCompute(Stack<IRPNComputable> lexems)
        {
            var rArg = lexems.Pop() as Number;

            var lArg = lexems.Peek() as Number;

            lArg.Value = this.Calculate(lArg.Value, rArg.Value);
        }

        internal abstract double Calculate(double lArg, double rArg);
    }
}