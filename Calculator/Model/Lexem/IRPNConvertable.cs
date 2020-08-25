using System.Collections.Generic;

namespace Calculator
{
    internal interface IRPNConvertable
    {
        public void RPNConvert(Stack<Sign> signs, LinkedList<ILexem> lexems);
    }
}