using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    internal class TanFabric : ILexemFabric
    {
        ILexem ILexemFabric.Create(ILexem prev, string str)
        {
            return new Tan();
        }
    }
}