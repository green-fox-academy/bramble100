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
            string testString = "3 + 4 + 54";
            Console.WriteLine(testString);
            Console.WriteLine(MyCalculator(testString));
            Console.ReadKey();
        }

        static double MyCalculator(string CalculatorString)
        {
            char[] enabledOperators = { '+' };
            string[] calculatorStringArray = CalculatorString.Split(' ');
            Queue<string> calculatorStringList = new Queue<string>(calculatorStringArray);
            double number1 = GetNextNumber();
            double result = number1;

            while (calculatorStringList.Count >= 2)
            {
                char nextOperator = GetNextOperator();
                double number2 = GetNextNumber();
                if (nextOperator=='+')
                {
                    result += number2;
                }
            }
            return result;

            double GetNextNumber()
            {
                return Int32.Parse(calculatorStringList.Dequeue());
            }

            char GetNextOperator()
            {
                return Char.Parse(calculatorStringList.Dequeue());
            }
        }
    }
}
