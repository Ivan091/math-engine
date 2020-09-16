using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.RegularExpressions;

namespace Calculator
{
    internal class LexicalAnalyzer
    {
        private struct FabricMatchPair : IComparable<FabricMatchPair>
        {
            internal ILexemFabric Fabric { get; private set; }

            internal Match Match { get; private set; }

            internal FabricMatchPair(ILexemFabric fabric, Match match)
            {
                Fabric = fabric;
                Match = match;
            }

            public int CompareTo([AllowNull] FabricMatchPair other)
            {
                return this.Match.Index - other.Match.Index;
            }
        }

        private string Input { get; set; }

        /// <summary>
        ///  To add new Lexems u need to create :
        /// new Lexem class : ILexem or Sign or their any childes
        /// add new fabric : ILexemfabric and add the fabric to this dictionary
        /// </summary>
        private Dictionary<ILexemFabric, Regex> LexemToRegex { get; } = new Dictionary<ILexemFabric, Regex>
        {
            // Numbers and constants
            { new NumberFabric(), new Regex(@"\d+(?:\.\d+)?") },
            { new PiConstFabric(), new Regex(@"PI") },
            { new EConstFabric(), new Regex(@"E") },

            // Common operators
            { new MinusFabric(), new Regex(@"-") },
            { new PlusFabric(), new Regex(@"\+") },
            { new CommaFabric(), new Regex(@",") },

            // Binary operators
            { new DivideFabric(), new Regex(@"/") },
            { new MultiplyFabric(), new Regex(@"\*") },
            { new PowerFabric(), new Regex(@"\^") },

            // Brackets
            { new LBracketFabric(), new Regex(@"\(") },
            { new RBracketFabric(), new Regex(@"\)") },
            { new ModulBracketFabric(), new Regex(@"\|") },

            // Functions
            { new ExponentFabric(), new Regex(@"exp") },
            { new FactorialFabric(), new Regex(@"!") },
            { new ModulFabric(), new Regex(@"abs") },
            { new PowerFabric(), new Regex(@"pow") },
            { new TanFabric(), new Regex(@"tan") },
            { new CosFabric(), new Regex(@"cos") },
            { new SinFabric(), new Regex(@"sin") },
            { new NaturalLogathmFabric(), new Regex(@"ln") },
            { new CustomLogarithmFabric(), new Regex(@"log") },
        };

        internal LexicalAnalyzer(string input)
        {
            Input = input;
        }

        internal IEnumerable<ILexem> Analyse()
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
    }
}