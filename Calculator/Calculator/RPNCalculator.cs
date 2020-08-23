using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class RPNCalculator
    {
        private IEnumerable<ILexem> Lexems { get; set; }
        public RPNCalculator(IEnumerable<ILexem> lexems)
        {
            Lexems = lexems;
        }

        public double Calculate ()
        {
            var stack = new Stack<ILexem>();

            foreach (var lexem in Lexems)
            {
                lexem.RPNCalculate(stack);
            }

            return (stack.Peek() as Number).Value;
        }
    }
}
