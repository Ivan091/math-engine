namespace Calculator
{
    internal class Multiply : BinOperator
    {
        protected internal override Priority Priority => Priority.AsMiltiply;

        internal override double Calculate(double lArg, double rArg)
        {
            return lArg * rArg;
        }
    }
}