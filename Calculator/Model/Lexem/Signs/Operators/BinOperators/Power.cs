using System;

namespace Calculator
{
    internal class Power : BinOperator
    {
        protected override Priority Priority => Priority.AsPower;

        public override double Calculate(double lArg, double rArg)
        {
            return Math.Pow(lArg, rArg);
        }
    }
}