using System.Collections.Generic;

namespace Calculator
{
    internal class LModul : LBracket
    {
        public override void RPNConvert(Stack<Sign> signs, LinkedList<ILexem> lexems)
        {
            signs.Push(this);
        }
    }
}