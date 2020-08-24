namespace Calculator
{
    internal class ExponentFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            return new Exponent();
        }
    }
}