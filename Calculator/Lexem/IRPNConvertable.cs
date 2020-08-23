using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public interface IRPNConvertable
    {
        public void RPNConvert(Stack<Sign> signs, LinkedList<Lexem> lexems);
    }
}
