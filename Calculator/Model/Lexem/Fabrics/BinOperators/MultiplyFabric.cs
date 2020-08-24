namespace Calculator
{
    public class MultiplyFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            return new Multiply();
        }
    }
}
