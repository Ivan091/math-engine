namespace Calculator
{
    internal class PlusFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            if (prev is ILBracket || prev is null)
                return new UnPlus();
            return new BinPlus();
        }
    }
}