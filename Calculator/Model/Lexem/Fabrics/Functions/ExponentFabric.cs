using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    class ExponentFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            return new Exponent();
        }
    }
}
