namespace Calculator
{
    internal class BinMinus : BinOperator
    {
        protected internal override Priority Priority => Priority.AsPlus;

        internal override double Calculate(double lArg, double rArg)
        {
            return lArg - rArg;
        }
    }
}