using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class PlusFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            if (prev is LBracket || prev is null)
                return new UnPlus();
            return new BinPlus();
        }
    }
}
