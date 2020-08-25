using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    internal class NaturalLogathmFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            return new NaturalLogarithm();
        }
    }
}