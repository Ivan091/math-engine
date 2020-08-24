using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class RBracket : Sign
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
