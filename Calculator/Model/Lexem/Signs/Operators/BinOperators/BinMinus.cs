using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class BinMinus : BinOperator
    {
        public override Priority Priority => Priority.AsPlus;

        public override double Compute(double lArg, double rArg)
        {
            return lArg - rArg;
        }
    }
}
