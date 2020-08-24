namespace Calculator
{
    internal class NumberFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            return new Number(double.Parse(str));
        }
    }
}