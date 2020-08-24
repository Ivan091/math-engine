namespace Calculator
{
    internal class BinMinus : BinOperator
    {
        public override Priority Priority => Priority.AsPlus;

        public override double Calculate(double lArg, double rArg)
        {
            return lArg - rArg;
        }
    }
}