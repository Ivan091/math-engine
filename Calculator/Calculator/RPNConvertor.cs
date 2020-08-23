using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Calculator
{
    class RPNConvertor
    {
        private IEnumerable<ILexem> Lexems { get; set; }
        public RPNConvertor(IEnumerable<ILexem> lexems)
        {
            Lexems = lexems;
        }
        public IEnumerable<ILexem> Convert ()
        {
            var signs = new Stack<BinSign>();
            var polSeq = new LinkedList<ILexem>();

            foreach (var lexem in Lexems)
            {
                lexem.RPNConvert(signs, polSeq);
            }

            while (signs.Count > 0)
            {
                polSeq.AddLast(signs.Peek());
                signs.Pop();
            }

            return polSeq;
        }
    }
}
