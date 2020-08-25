using System.Collections.Generic;

namespace Calculator
{
    internal class Number : ILexem
    {
        internal double Value { get; set; }

        internal Number(double num)
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