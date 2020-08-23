using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public abstract class BinSign : ILexem
    {

        public abstract double Calculate(double lNum, double rNum);

        public abstract ILexem Create(Match match);

        public void RPNCalculate(Stack<ILexem> lexems)
        {
            var rNum = lexems.Peek() as Number;
            lexems.Pop();
            var lNum = lexems.Peek() as Number;
            lexems.Pop();

            lexems.Push(new Number(this.Calculate(lNum.Value, rNum.Value)));
        }

        public void RPNConvert(Stack<BinSign> binSigns, LinkedList<ILexem> lexems)
        {
            binSigns.Push(this);
        }
    }
}
