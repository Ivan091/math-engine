using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Factorial : Function
    {
        public override double Compute(double arg)
        {
            var n = Math.Abs(arg);

            if (arg > 16)
                throw new ArgumentException($"Factorial of {arg} is too long");

            var fact = 1;

            for (var i = 1; i <=n; i++)
                fact *= i;

            return arg > 0 ? fact : -fact;
        }
    }
}
