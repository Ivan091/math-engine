using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class LBracket : Sign
    {
        public override Priority Priority => Priority.Bracket;

        public override Lexem CreateSame(Match match)
        {
            return new LBracket();
        }
        public override void RPNCalculate(Stack<IRPNCalculatable> lexems)
        {
            return;
        }

        public override void RPNConvert(Stack<Sign> signs, LinkedList<Lexem> lexems)
        {
            signs.Push(this);
        }
    }
}
