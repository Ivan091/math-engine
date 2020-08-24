using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class LBracket : Sign
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
