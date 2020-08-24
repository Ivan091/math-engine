using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class BinPlus : BinOperator
    {
        public override Priority Priority => Priority.AsPlus;

        public override double Compute(double lArg, double rArg)
        {
            return lArg + rArg;
        }
    }
}
