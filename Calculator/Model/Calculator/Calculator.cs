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
        private LexicalAnalyzer LexicalAnalyzer { get; set; }
        private RPNConverter RPNConverter { get; set; }
        private RPNComputer RPNComputer { get; set; }
        private string Input { get; set; }
        public Calculator(string input)
        {
            Input = input;
            
        }

        public double Calculate()
        {
            LexicalAnalyzer = new LexicalAnalyzer(Input);
            RPNConverter = new RPNConverter(LexicalAnalyzer.Analyse());
            RPNComputer = new RPNComputer(RPNConverter.Convert());
            return RPNComputer.Compute();

        }
    }
}
