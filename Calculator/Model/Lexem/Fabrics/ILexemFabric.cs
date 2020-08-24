using System.Text.RegularExpressions;

namespace Calculator
{
    public interface ILexemFabric
    {
        public ILexem Create(ILexem prev, string str);

        public ILexemFabric CreateSame() => this;
    }
}
