﻿using System.Collections.Generic;

namespace Calculator
{
    internal class RPNComputer
    {
        private IEnumerable<IRPNComputable> Lexems { get; set; }

        public RPNComputer(IEnumerable<IRPNComputable> lexems)
        {
            Lexems = lexems;
        }

        public double Compute()
        {
            var stack = new Stack<IRPNComputable>();

            foreach (var lexem in Lexems)
            {
                lexem.RPNCompute(stack);
            }

            return (stack.Peek() as Number).Value;
        }
    }
}