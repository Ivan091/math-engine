using System.Collections.Generic;

namespace Calculator
{
    public interface IRPNConvertable
    {
        public void RPNConvert(Stack<Sign> signs, LinkedList<ILexem> lexems);
    }
}
