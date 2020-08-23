using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public interface IRPNCalculatable
    {
        public abstract void RPNCalculate(Stack<IRPNCalculatable> lexems);
    }
}
