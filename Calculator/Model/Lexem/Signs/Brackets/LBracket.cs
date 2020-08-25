using System;
using System.Collections.Generic;

namespace Calculator
{
    internal abstract class LBracket : Sign, ILBracket
    {
        protected internal override Priority Priority => Priority.AsBracket;

        public override void RPNCompute(Stack<IRPNComputable> lexems)
        {
            throw new NotImplementedException();
        }

        public override void RPNConvert(Stack<Sign> signs, LinkedList<ILexem> lexems)
        {
            signs.Push(this);
        }
    }
}