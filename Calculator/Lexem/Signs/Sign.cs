using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public enum Priority
    {
        Bracket,
        Plus,
        Miltiply,
        Power,
        Function
    };

    public abstract class Sign : Lexem
    {
        public abstract Priority Priority { get; }
        public abstract override void RPNCalculate(Stack<Lexem> lexems);
        public abstract override Lexem CreateSame(Match match);
        public override void RPNConvert(Stack<Sign> signs, LinkedList<Lexem> lexems)
        {
            while (signs.Count > 0 && signs.Peek().Priority > this.Priority)
            {
                lexems.AddLast(signs.Peek());
                signs.Pop();
            }
            signs.Push(this);
        }
    }
}
