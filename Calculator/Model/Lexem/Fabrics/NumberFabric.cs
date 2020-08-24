using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    class NumberFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            return new Number(double.Parse(str));
        }
    }
}
