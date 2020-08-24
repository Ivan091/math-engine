namespace Calculator
{
    public interface ILexemFabric
    {
        public ILexem Create(ILexem prev, string str);
    }
}