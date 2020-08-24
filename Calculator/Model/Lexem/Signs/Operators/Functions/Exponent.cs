using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class Exponent : Function
    {
        public override double Compute(double arg)
        {
            return Math.Exp(arg);
        }
    }
}
