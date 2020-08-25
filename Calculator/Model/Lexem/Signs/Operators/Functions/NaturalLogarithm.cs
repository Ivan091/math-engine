using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    internal class NaturalLogarithm : Function
    {
        internal override double Calculate(double[] args)
        {
            return Math.Log(args[0]);
        }
    }
}