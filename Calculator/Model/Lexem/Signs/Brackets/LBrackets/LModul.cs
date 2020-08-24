using System;
using System.Collections.Generic;

namespace Calculator
{
    internal class LModul : LBracket
    {
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