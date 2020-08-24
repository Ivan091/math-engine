using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    class LexicalAnalyzer
    {
        private Dictionary<ILexemFabric, Regex> LexemToRegex { get; } = new Dictionary<ILexemFabric, Regex>
        {
            // Common operators
            { new NumberFabric(), new Regex(@"\d+(?:\.\d+)?") },
            { new MinusFabric(), new Regex(@"-") },
            { new PlusFabric(), new Regex(@"\+") },

            // Binary operators
            { new DivideFabric(), new Regex(@"/") },
            { new MultiplyFabric(), new Regex(@"\*") },

            // Brackets
            { new LBracketFabric(), new Regex(@"\(") },
            { new RBracketFabric(), new Regex(@"\)") },

            // Functions
            { new ExponentFabric(), new Regex(@"exp") },
            { new FactorialFabric(), new Regex(@"!") }
        };
        private string Input { get; set; }

        public LexicalAnalyzer(string input)
        {
            Input = input;
        }
        public IEnumerable<ILexem> Analyse()
        {
            var matches = new SortedSet<FabricMatchPair>();
            foreach (var fabricMatchPair in LexemToRegex)
            {
                fabricMatchPair.Value.Matches(Input).ToList().ForEach(x => matches.Add(new FabricMatchPair(fabricMatchPair.Key, x)));
            }

            var cur = matches.GetEnumerator();
            cur.MoveNext();

            var lexems = new LinkedList<ILexem>();

            lexems.AddLast(cur.Current.Fabric.Create(null, cur.Current.Match.Value));

            var prev = lexems.First;

            while (cur.MoveNext())
            {
                lexems.AddLast(cur.Current.Fabric.Create(prev.Value, cur.Current.Match.Value));
                prev = prev.Next;
            }

            return lexems;

        }

        private struct FabricMatchPair : IComparable<FabricMatchPair>
        {
            public ILexemFabric Fabric { get; private set; }
            public Match Match { get; private set; }

            public FabricMatchPair(ILexemFabric fabric, Match match)
            {
                Fabric = fabric;
                Match = match;
            }

            public int CompareTo([AllowNull] FabricMatchPair other)
            {
                return this.Match.Index - other.Match.Index;
            }
        }

    }
}
