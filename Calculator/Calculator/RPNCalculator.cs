using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class RPNCalculator
    {
        private IEnumerable<IRPNCalculatable> Lexems { get; set; }
        public RPNCalculator(IEnumerable<IRPNCalculatable> lexems)
        {
            Lexems = lexems;
        }

        public double Calculate ()
        {
            var stack = new Stack<Lexem>();

            foreach (var lexem in Lexems)
            {
                lexem.RPNCalculate(stack);
            }

            return (stack.Peek() as Number).Value;
        }
    }
}
