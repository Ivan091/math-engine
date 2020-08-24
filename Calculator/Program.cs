using System;

namespace Calculator
{
    internal class Program
    {
        public static void Main()
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