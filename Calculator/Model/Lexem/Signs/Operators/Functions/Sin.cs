using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    internal class Sin : Function
    {
        internal override double Calculate(double[] args)
        {
            return Math.Sin(args[0]);
        }
    }
}