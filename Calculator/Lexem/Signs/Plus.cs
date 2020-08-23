using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class Plus : BinSign
    {
        public override double Calculate(double lNum, double rNum)
        {
            return lNum + rNum;
        }

        public override ILexem Create(Match match)
        {
            return new Plus();
        }
    }
}
