using System.Collections.Generic;

namespace Calculator
{
    public interface IRPNComputable
    {
        public abstract void RPNCompute(Stack<IRPNComputable> lexems);
    }
}