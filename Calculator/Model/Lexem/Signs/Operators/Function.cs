using System.Collections.Generic;

namespace Calculator
{
    public abstract class Function : Sign
    {
        protected virtual int OperandCount => 1;

        protected override Priority Priority => Priority.AsFunction;

        public abstract double Calculate(double[] args);

        public override void RPNCompute(Stack<IRPNComputable> lexems)
        {
            var arg = lexems.Peek() as Number;

            var args = new double[OperandCount];

            for (var i = 0; i < OperandCount - 1; i++)
            {
                args[args.Length - i - 1] = (lexems.Pop() as Number).Value;
            }

            args[0] = (lexems.Peek() as Number).Value;

            (lexems.Peek() as Number).Value = this.Calculate(args);
        }
    }
}