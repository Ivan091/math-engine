namespace Calculator
{
    internal class Multiply : BinOperator
    {
        protected override Priority Priority => Priority.AsMiltiply;

        public override double Calculate(double lArg, double rArg)
        {
            return lArg * rArg;
        }
    }
}