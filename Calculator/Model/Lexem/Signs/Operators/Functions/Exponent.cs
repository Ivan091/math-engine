﻿using System;

namespace Calculator
{
    internal class Exponent : Function
    {
        public override double Calculate(double arg)
        {
            return Math.Exp(arg);
        }
    }
}