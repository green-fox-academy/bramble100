using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://www.codewars.com/kata/calculator
// Create a simple calculator that given a string of operators (+ - * and /) 
// and numbers separated by spaces returns the value of that expression
// Calculator().evaluate("2 / 2 + 3 * 4 - 6") # => 7

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "6 + 4 + 54 + 4.5 - 5";
            testString = Console.ReadLine();
            CalculatorEngine Calc = new CalculatorEngine(testString);
            Console.WriteLine(Calc.PerformCalculation());
            Console.ReadKey();
        }
    }
}
