using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public abstract class Function : Sign
    {
        public override Priority Priority => Priority.AsFunction;

        public abstract double Compute(double arg);
        public override void RPNCompute(Stack<IRPNComputable> lexems)
        {
            var arg = lexems.Peek() as Number;
            arg.Value = this.Compute(arg.Value);
        }
    }
}
