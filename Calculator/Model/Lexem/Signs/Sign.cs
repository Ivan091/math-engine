using System.Collections.Generic;

namespace Calculator
{
    public enum Priority
    {
        // Brackets must have the lowest priority.
        AsBracket,

        AsPlus,
        AsMiltiply,
        AsPower,
        AsFunction,
    };

    public abstract class Sign : ILexem
    {
        public abstract Priority Priority { get; }
        public abstract void RPNCompute(Stack<IRPNComputable> lexems);
        public virtual void RPNConvert(Stack<Sign> signs, LinkedList<ILexem> lexems)
        {
            while (signs.Count > 0 && signs.Peek().Priority >= this.Priority)
            {
                lexems.AddLast(signs.Peek());
                signs.Pop();
            }
            signs.Push(this);
        }
    }
}
