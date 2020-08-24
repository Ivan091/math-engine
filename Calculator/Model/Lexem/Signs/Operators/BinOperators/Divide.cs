namespace Calculator
{
    internal class Divide : BinOperator
    {
        public override Priority Priority => Priority.AsMiltiply;

        public override double Calculate(double lArg, double rArg)
        {
            return lArg / rArg;
        }
    }
}