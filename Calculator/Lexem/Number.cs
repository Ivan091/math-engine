using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Number : Lexem
    {
        public double Value { get; set; }

        public Number(double num = 0)
        {
            Value = num;
        }
        public override Lexem CreateSame(Match match)
        {
            return new Number()
            { Value = double.Parse(match.Value) };
        }

        public override void RPNCalculate(Stack<IRPNCalculatable> lexems)
        {
            lexems.Push(this);
        }

        public override void RPNConvert(Stack<Sign> signs, LinkedList<Lexem> lexems)
        {
            lexems.AddLast(this);
        }
    }
}
