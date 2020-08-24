using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Program
    {
        static void Main()
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
