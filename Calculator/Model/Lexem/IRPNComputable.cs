using System.Collections.Generic;

namespace Calculator
{
    internal interface IRPNComputable
    {
        public abstract void RPNCompute(Stack<IRPNComputable> lexems);
    }
}