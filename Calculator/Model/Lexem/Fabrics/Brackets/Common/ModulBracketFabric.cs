namespace Calculator
{
    internal class ModulBracketFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            if (prev is BinOperator || prev == null)
                return new LModul();
            return new RModul();
        }
    }
}