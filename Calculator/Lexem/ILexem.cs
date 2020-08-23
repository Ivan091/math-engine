using Calculator.Lexem;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator
{
    public interface ILexem : IRPNCalculatable, IRPNConvertable
    {
        public ILexem Create(Match match);
    }
}
