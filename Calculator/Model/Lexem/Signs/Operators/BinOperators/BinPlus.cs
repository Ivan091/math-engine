namespace Calculator
{
    internal class BinPlus : BinOperator
    {
        protected internal override Priority Priority => Priority.AsPlus;

        internal override double Calculate(double lArg, double rArg)
        {
            return lArg + rArg;
        }
    }
}