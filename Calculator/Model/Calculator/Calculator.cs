namespace Calculator
{
    public class Calculator
    {
        private string Input { get; set; }

        private LexicalAnalyzer LexicalAnalyzer { get; set; }

        private RPNComputer RPNComputer { get; set; }

        private RPNConverter RPNConverter { get; set; }

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