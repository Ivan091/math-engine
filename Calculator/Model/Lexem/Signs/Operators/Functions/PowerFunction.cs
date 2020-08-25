using System;

namespace Calculator
{
    internal class PowerFunction : Function
    {
        protected override int OperandCount => 2;

        public override double Calculate(double[] args)
        {
            return Math.Pow(args[0], args[1]);
        }
    }
}