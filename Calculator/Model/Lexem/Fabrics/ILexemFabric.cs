namespace Calculator
{
    internal interface ILexemFabric
    {
        public ILexem Create(ILexem prev, string str);
    }
}