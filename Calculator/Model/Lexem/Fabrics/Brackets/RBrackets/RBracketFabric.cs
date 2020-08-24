namespace Calculator
{
    internal class RBracketFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            return new RRoundBracket();
        }
    }
}