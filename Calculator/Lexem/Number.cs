using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Number : ILexem
    {
        public double Value { get; private set; }

        public Number(double num = 0)
        {
            Value = num;
        }
        public ILexem Create(Match match)
        {
            return new Number()
            { Value = double.Parse(match.Value) };
        }

        public void RPNCalculate(Stack<ILexem> lexems)
        {
            lexems.Push(this);
        }

        public void RPNConvert(Stack<BinSign> binSigns, LinkedList<ILexem> lexems)
        {
            lexems.AddLast(this);
        }
    }
}
