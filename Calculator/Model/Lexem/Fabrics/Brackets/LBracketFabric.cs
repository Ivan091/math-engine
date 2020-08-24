using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class LBracketFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            return new LBracket();
        }
    }
}
