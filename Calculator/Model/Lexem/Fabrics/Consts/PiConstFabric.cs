namespace Calculator
{
    internal class PiConstFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            return new PiConst();
        }
    }
}