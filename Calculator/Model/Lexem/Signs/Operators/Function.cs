using System.Collections.Generic;

namespace Calculator
{
    internal abstract class Function : Sign
    {
        protected internal override Priority Priority => Priority.AsFunction;

        protected virtual int OperandCount => 1;

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

        internal abstract double Calculate(double[] args);
    }
}