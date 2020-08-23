using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Lexem
{
    public interface IRPNConvertable
    {
        public void RevPolNotConvert(Stack<BinSign> binSigns, LinkedList<ILexem> lexems);
    }
}
