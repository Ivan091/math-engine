namespace Calculator
{
    internal class DivideFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            return new Divide();
        }
    }
}