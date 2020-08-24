using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class FactorialFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            return new Factorial();
        }
    }
}
