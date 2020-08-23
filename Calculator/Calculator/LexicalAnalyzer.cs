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
        private Dictionary<ILexem, Regex> LexemToRegex { get; } = new Dictionary<ILexem, Regex>
        {
            { new Number(), new Regex(@"\d+(?:\.\d+)?") },
            { new Minus(), new Regex(@"-") },
            { new Plus(), new Regex(@"\+") },
        };
        private string Input { get; set; }

        public LexicalAnalyzer(string input)
        {
            Input = input;
        }
        public IEnumerable<ILexem> Analyse()
        {
            var matches = new SortedSet<(ILexem, int)>(new LexemIdxCoomparer());
            foreach (var lexem in LexemToRegex)
            {
                lexem.Value.Matches(Input).ToList().ForEach(x => matches.Add((lexem.Key.Create(x), x.Index)));
            }
            return matches.Select(x => x.Item1);
        }

        class LexemIdxCoomparer : IComparer<(ILexem, int)>
        {
            public int Compare([AllowNull] (ILexem, int) x, [AllowNull] (ILexem, int) y)
            {
                return x.Item2 - y.Item2;
            }
        }

    }
}
