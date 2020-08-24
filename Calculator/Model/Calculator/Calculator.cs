using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class Calculator
    {
        public Calculator(string input)
        {
            LexicalAnalyzer = new LexicalAnalyzer(input);
        }

        public double Calculate()
        {
            RPNConvertor = new RPNConvertor(LexicalAnalyzer.Analyse());
            RPNCalculator = new RPNComputer(RPNConvertor.Convert());
            return RPNCalculator.Calculate();

        }
        private LexicalAnalyzer LexicalAnalyzer { get; set; }
        private RPNConvertor RPNConvertor { get; set; }
        private RPNComputer RPNCalculator { get; set; }
    }
}
