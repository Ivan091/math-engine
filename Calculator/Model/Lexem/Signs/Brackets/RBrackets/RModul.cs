using System.Collections.Generic;

namespace Calculator
{
    internal class RModul : RBracket
    {
        public override void RPNConvert(Stack<Sign> signs, LinkedList<ILexem> lexems)
        {
            base.RPNConvert(signs, lexems);
            lexems.AddLast(new ModulFunction());
        }
    }
}