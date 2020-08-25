using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    internal class Cos : Function
    {
        internal override double Calculate(double[] args)
        {
            return Math.Cos(args[0]);
        }
    }
}