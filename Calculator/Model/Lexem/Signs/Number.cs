using System.Collections.Generic;

namespace Calculator
{
    internal class Number : ILexem
    {
        public double Value { get; set; }

        public Number(double num)
        {
            Value = num;
        }

        public void RPNCompute(Stack<IRPNComputable> lexems)
        {
            lexems.Push(this);
        }

        public void RPNConvert(Stack<Sign> signs, LinkedList<ILexem> lexems)
        {
            lexems.AddLast(this);
        }
    }
}