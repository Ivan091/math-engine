using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class Multiply : BinSign
    {
        public override Priority Priority => Priority.Miltiply;

        public override double Compute(double lArg, double rArg)
        {
            return lArg * rArg;
        }

        public override Lexem CreateSame(Match match)
        {
            return new Multiply();
        }
    }
}
