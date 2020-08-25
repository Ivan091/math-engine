namespace Calculator
{
    internal class Calculator
    {
        private string Input { get; set; }

        private LexicalAnalyzer LexicalAnalyzer { get; set; }

        private RPNComputer RPNComputer { get; set; }

        private RPNConverter RPNConverter { get; set; }

        internal Calculator(string input)
        {
            Input = input;
        }

        internal double Calculate()
        {
            LexicalAnalyzer = new LexicalAnalyzer(Input);
            RPNConverter = new RPNConverter(LexicalAnalyzer.Analyse());
            RPNComputer = new RPNComputer(RPNConverter.Convert());
            return RPNComputer.Compute();
        }
    }
}