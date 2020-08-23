using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class RBracket : Sign
    {
        public override Priority Priority => Priority.Bracket;

        public override Lexem CreateSame(Match match)
        {
            return new RBracket();
        }
        public override void RPNCalculate(Stack<Lexem> lexems)
        {
            return;
        }

        public override void RPNConvert(Stack<Sign> signs, LinkedList<Lexem> lexems)
        {
            while (signs.Peek() is LBracket == false)
            {
                lexems.AddLast(signs.Peek());
                signs.Pop();
            }
            signs.Pop();
        }
    }
}
