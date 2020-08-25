using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Calculator
{
    internal abstract class Sign : ILexem, IComparable<Sign>
    {
        protected internal virtual Accession Accession => Accession.Middle;

        protected internal abstract Priority Priority { get; }

        public int CompareTo([AllowNull] Sign other)
        {
            if (this.Priority.CompareTo(other.Priority) != 0)
            {
                return this.Priority.CompareTo(other.Priority);
            }

            if (this.Accession <= other.Accession)
                return 1;
            else return 0;
        }

        public abstract void RPNCompute(Stack<IRPNComputable> lexems);

        public virtual void RPNConvert(Stack<Sign> signs, LinkedList<ILexem> lexems)
        {
            while (signs.Count > 0 && signs.Peek().CompareTo(this) > 0)
            {
                lexems.AddLast(signs.Peek());
                signs.Pop();
            }
            signs.Push(this);
        }
    }

    /// <summary>
    /// Additional comparing operation while converting.
    /// Necessary because there are prefix and postfix operations.
    /// </summary>
    internal enum Accession
    {
        Middle,

        Left,

        Right,
    };

    internal enum Priority
    {
        // Brackets must have the lowest priority.
        AsBracket,

        AsPlus,

        AsMiltiply,

        AsPower,

        AsFunction,
    };
}