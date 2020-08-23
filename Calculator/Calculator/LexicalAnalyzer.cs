using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    class LexicalAnalyzer
    {
        private Dictionary<Lexem, Regex> LexemToRegex { get; } = new Dictionary<Lexem, Regex>
        {
            { new Number(), new Regex(@"\d+(?:\.\d+)?") },
            { new Minus(), new Regex(@"-") },
            { new Plus(), new Regex(@"\+") },
            { new Divide(), new Regex(@"/") },
            { new Multiply(), new Regex(@"\*") },
            { new LBracket(), new Regex(@"\(") },
            { new RBracket(), new Regex(@"\)") },
            { new Exponent(), new Regex(@"exp") },
        };
        private string Input { get; set; }

        private struct LexemIdxPair : IComparable<LexemIdxPair>
        {
            public LexemIdxPair(Lexem lexem, int idx)
            {
                Lexem = lexem;
                Idx = idx;
            }
            public Lexem Lexem { get; set; }
            public int Idx { get; set; }

            public int CompareTo([AllowNull] LexemIdxPair other)
            {
                return this.Idx - other.Idx;
            }
        }

        public LexicalAnalyzer(string input)
        {
            Input = input;
        }
        public IEnumerable<Lexem> Analyse()
        {


            var matches = new SortedSet<LexemIdxPair>();
            foreach (var lexem in LexemToRegex)
            {
                lexem.Value.Matches(Input).ToList().ForEach(x => matches.Add(new LexemIdxPair(lexem.Key.CreateSame(x), x.Index)));
            }
            return matches.Select(x => x.Lexem);
        }
    }
}
