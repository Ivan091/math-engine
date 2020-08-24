using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class MinusFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            if (prev is LBracket || prev is null)
                return new UnMinus();
            return new BinMinus();
        }
    }
}
