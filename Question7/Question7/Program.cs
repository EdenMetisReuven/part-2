﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    internal class Program
    {
        static void Main()
        {
            NumericalExpression num = new NumericalExpression(2);
            Console.WriteLine("The number is: " + num.GetValue());
            Console.WriteLine("The number in word is: " + num.ToString());
            //int lettersCount = NumericalExpression.SumLetters(123456)
            Console.WriteLine("The letters sum is: " + num.SumLetters());

        }
    }
}