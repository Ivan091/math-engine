namespace Calculator
{
    internal class PowerFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            return new Power();
        }
    }
}