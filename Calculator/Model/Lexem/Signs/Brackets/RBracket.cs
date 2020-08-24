using System.Collections.Generic;

namespace Calculator
{
    internal abstract class RBracket : Sign
    {
        public override Priority Priority => Priority.AsBracket;

        public override void RPNCompute(Stack<IRPNComputable> lexems)
        {
            return;
        }

        public override void RPNConvert(Stack<Sign> signs, LinkedList<ILexem> lexems)
        {
            while (signs.Peek() is LBracket == false)
            {
                lexems.AddLast(signs.Pop());
            }
            signs.Pop();
        }
    }
}