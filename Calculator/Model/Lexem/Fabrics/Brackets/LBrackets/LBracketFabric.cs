namespace Calculator
{
    internal class LBracketFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            return new LRoundBracket();
        }
    }
}