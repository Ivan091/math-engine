namespace Calculator
{
    internal class BinPlus : BinOperator
    {
        public override Priority Priority => Priority.AsPlus;

        public override double Calculate(double lArg, double rArg)
        {
            return lArg + rArg;
        }
    }
}