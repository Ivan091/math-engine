namespace Calculator
{
    internal class MinusFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            if (prev is LBracket || prev is null)
                return new UnMinus();
            return new BinMinus();
        }
    }
}