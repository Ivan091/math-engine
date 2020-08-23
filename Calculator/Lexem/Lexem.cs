using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Calculator
{
    public abstract class Lexem : IRPNConvertable, IRPNCalculatable
    {
        public abstract Lexem CreateSame(Match match);

        public abstract void RPNCalculate(Stack<IRPNCalculatable> lexems);

        public abstract void RPNConvert(Stack<Sign> signs, LinkedList<Lexem> lexems);
    }
}
