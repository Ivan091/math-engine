namespace Calculator
{
    internal class CommaFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            return new Comma();
        }
    }
}