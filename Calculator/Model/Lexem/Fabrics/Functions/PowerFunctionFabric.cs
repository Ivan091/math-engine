namespace Calculator
{
    internal class PowerFunctionFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            return new PowerFunction();
        }
    }
}