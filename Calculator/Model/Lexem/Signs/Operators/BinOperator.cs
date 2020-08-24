using System.Collections.Generic;

namespace Calculator
{
    public abstract class BinOperator : Sign
    {
        public abstract double Calculate(double lArg, double rArg);

        public override void RPNCompute(Stack<IRPNComputable> lexems)
        {
            var rArg = lexems.Pop() as Number;

            var lArg = lexems.Peek() as Number;

            lArg.Value = this.Calculate(lArg.Value, rArg.Value);
        }
    }
}