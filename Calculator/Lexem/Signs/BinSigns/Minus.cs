using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class Minus : BinSign
    {
        public override Priority Priority => Priority.Plus;

        public override double Calculate(double lNum, double rNum)
        {
            return lNum - rNum;
        }

        public override Lexem CreateSame(Match match)
        {
            return new Minus();
        }
    }   
}
