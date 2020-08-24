using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    class UnPlus : Function
    {
        public override double Compute(double arg)
        {
            return arg;
        }
    }
}
