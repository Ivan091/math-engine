using System;

namespace Calculator
{
    internal class Factorial : Function
    {
        protected internal override Accession Accession => Accession.Right;

        internal override double Calculate(double[] args)
        {
            var n = Math.Abs(args[0]);

            if (args[0] > 16)
                throw new ArgumentException($"Factorial of {args[0]} is too long");

            var fact = 1;

            for (var i = 1; i <= n; i++)
                fact *= i;

            return args[0] > 0 ? fact : -fact;
        }
    }
}