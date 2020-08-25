using System;

namespace Calculator
{
    internal class Modul : Function
    {
        public override double Calculate(double[] args)
        {
            return Math.Abs(args[0]);
        }
    }
}