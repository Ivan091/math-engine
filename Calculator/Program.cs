using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            var calc = new Calculator("2+2-10");
            Console.WriteLine(calc.Calculate());
        }
    }
}
