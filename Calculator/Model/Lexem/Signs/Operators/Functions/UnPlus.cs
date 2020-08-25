namespace Calculator
{
    internal class UnPlus : Function
    {
        protected internal override Accession Accession => Accession.Left;

        internal override double Calculate(double[] args)
        {
            return args[0];
        }
    }
}