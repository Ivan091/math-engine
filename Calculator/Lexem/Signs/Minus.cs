using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class Minus : BinSign
    {
        public override double Calculate(double lNum, double rNum)
        {
            return lNum - rNum;
        }

        public override ILexem Create(Match match)
        {
            return new Minus();
        }
    }   
}
