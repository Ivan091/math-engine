namespace Calculator
{
    internal class FactorialFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            return new Factorial();
        }
    }
}