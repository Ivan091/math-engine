using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class Divide : BinOperator
    {
        public override Priority Priority => Priority.AsMiltiply;

        public override double Compute(double lArg, double rArg)
        {
            return lArg / rArg;
        }
    }
}
