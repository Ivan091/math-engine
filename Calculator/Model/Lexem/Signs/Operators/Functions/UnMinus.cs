using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    class UnMinus : Function
    {
        public override double Compute(double arg)
        {
            return -arg;
        }
    }
}
