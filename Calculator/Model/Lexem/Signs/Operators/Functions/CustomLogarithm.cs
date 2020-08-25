using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    internal class CustomLogarithm : Function
    {
        protected override int OperandCount => 2;

        internal override double Calculate(double[] args)
        {
            return Math.Log(args[1]) / Math.Log(args[0]);
        }
    }
}