using System;

namespace Calculator
{
    internal class Modul : Function
    {
        public override double Calculate(double arg)
        {
            return Math.Abs(arg);
        }
    }
}