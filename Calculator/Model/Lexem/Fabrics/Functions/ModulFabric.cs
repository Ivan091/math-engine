namespace Calculator
{
    internal class ModulFabric : ILexemFabric
    {
        public ILexem Create(ILexem prev, string str)
        {
            return new Modul();
        }
    }
}