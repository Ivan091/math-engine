using System.Collections.Generic;

namespace Calculator
{
    public abstract class Function : Sign
    {
        public override Priority Priority => Priority.AsFunction;

        public abstract double Calculate(double arg);

        public override void RPNCompute(Stack<IRPNComputable> lexems)
        {
            var arg = lexems.Peek() as Number;
            arg.Value = this.Calculate(arg.Value);
        }
    }
}