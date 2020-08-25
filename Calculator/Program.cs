using System;

namespace Calculator
{
    internal class Program
    {
        internal static void Main()
        {
            Run();
            return;
            var calc = new Calculator("exp(2)");
            Console.WriteLine(calc.Calculate());
        }

        private static void Run()
        {
            while (true)
            {
                var s = Console.ReadLine();
                var calc = new Calculator(s);
                try
                {
                    Console.WriteLine(calc.Calculate());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}