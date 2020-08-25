using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    internal class Tan : Function
    {
        internal override double Calculate(double[] args)
        {
            return Math.Tan(args[0]);
        }
    }
}