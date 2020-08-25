namespace Calculator
{
    internal class UnMinus : Function
    {
        public override double Calculate(double[] args)
        {
            return -args[0];
        }
    }
}