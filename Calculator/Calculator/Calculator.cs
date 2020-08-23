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
            RevPolNotConverter = new RPNConvertor(LexicalAnalyzer.Analyse());
            RPNCalculator = new RPNCalculator(RevPolNotConverter.Convert());
            return RPNCalculator.Calculate();

        }


        private LexicalAnalyzer LexicalAnalyzer { get; set; }
        private RPNCalculator RPNCalculator { get; set; }
        private RPNConvertor RevPolNotConverter { get; set; }
    }
}
