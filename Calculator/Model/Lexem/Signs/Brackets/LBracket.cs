﻿using System.Collections.Generic;

namespace Calculator
{
    internal abstract class LBracket : Sign
    {
        public override Priority Priority => Priority.AsBracket;

        public override void RPNCompute(Stack<IRPNComputable> lexems)
        {
            return;
        }

        public override void RPNConvert(Stack<Sign> signs, LinkedList<ILexem> lexems)
        {
            signs.Push(this);
        }
    }
}