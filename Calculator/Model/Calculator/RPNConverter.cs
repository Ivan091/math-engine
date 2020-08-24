using System.Collections.Generic;

namespace Calculator
{
    internal class RPNConverter
    {
        private IEnumerable<IRPNConvertable> Lexems { get; set; }

        public RPNConverter(IEnumerable<IRPNConvertable> lexems)
        {
            Lexems = lexems;
        }

        public IEnumerable<ILexem> Convert()
        {
            var signs = new Stack<Sign>();
            var polSeq = new LinkedList<ILexem>();

            foreach (var lexem in Lexems)
            {
                lexem.RPNConvert(signs, polSeq);
            }

            while (signs.Count > 0)
            {
                polSeq.AddLast(signs.Pop());
            }

            return polSeq;
        }
    }
}