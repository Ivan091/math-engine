using System;

namespace Calculator
{
    internal class Power : BinOperator
    {
        protected internal override Priority Priority => Priority.AsPower;

        internal override double Calculate(double lArg, double rArg)
        {
            return Math.Pow(lArg, rArg);
        }
    }
}