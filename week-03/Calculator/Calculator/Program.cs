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
            Console.WriteLine(testString);
            MyCalculator Calc = new MyCalculator(testString);
            Console.WriteLine(MyCalculator2(testString));
            Console.ReadKey();
        }

        static double MyCalculator(string CalculatorString)
        {
            char[] enabledOperators = { '+' };
            Queue<string> calculatorStringQueue = new Queue<string>(CalculatorString.Split(' '));
            double result = GetNextNumber();

            while (calculatorStringQueue.Count >= 2)
            {
                char nextOperator = GetNextOperator();
                double number = GetNextNumber();
                if (nextOperator=='+')
                {
                    result += number;
                }
                else if (nextOperator == '-')
                {
                    result -= number;
                }
            }
            return result;

            double GetNextNumber()
            {
                try
                {
                    return Double.Parse(calculatorStringQueue.Dequeue());
                }
                catch (FormatException)
                {
                    throw new ArgumentException("Invalid number in string");
                }
                
            }

            char GetNextOperator()
            {
                try
                {
                    return Char.Parse(calculatorStringQueue.Dequeue());
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        static double MyCalculator2(string CalculatorString)
        {
            List<string> calculatorStringList = new List<string>(CalculatorString.Split(' '));
            int cursor = FindNextMultiplication(0);
            while (cursor != 0)
            {
                CalculateNextMultiplication(cursor);
                cursor = FindNextMultiplication(cursor);
            }

            return Double.Parse(calculatorStringList.First());

            int FindNextMultiplication(int startPosition)
            {
                for (int i = startPosition; i < calculatorStringList.Count; i++)
                {
                    if (calculatorStringList[i] == "*")
                    {
                        return i;
                    }
                }
                return 0;
            }

            void CalculateNextMultiplication(int localCursor)
            {
                calculatorStringList[localCursor - 1] = (Double.Parse(calculatorStringList[localCursor - 1]) * Double.Parse(calculatorStringList[localCursor + 1])).ToString();
                if (calculatorStringList.Count > localCursor + 1)
                {
                    calculatorStringList.RemoveRange(localCursor, 2);
                }
            }
        }

    }

    public class MyCalculator
    {
        private string stringToCalculate;
        string validDigits = "0123456789.";
        string validOperators = "*/-+";

        public MyCalculator(string stringToCalculate)
        {
            if (IsValid(stringToCalculate))
            {
                this.stringToCalculate = stringToCalculate;
            }
        }

        private bool IsValid(string stringToCalculate)
        {
            string validCharacters = validDigits + validOperators + " ";

            foreach (var character in stringToCalculate)
            {
                if (!validCharacters.Contains(character))
                {
                    throw new ArgumentException("Invalid character in input string");
                }
            }
            return true;
        }

        private bool ContainsOnlyValidCharacters(string stringToValidate)
        {
            string validCharacters = validDigits + validOperators + " ";
            foreach (var character in stringToValidate)
            {
                if (!validCharacters.Contains(character))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsSyntacticallyCorrect(string stringToValidate)
        {
            bool operandCanCome = true;
            bool operatorCanCome = false;

            List<string> calculatorStringList = new List<string>(stringToValidate.Split(' '));
            foreach (var item in calculatorStringList)
            {
            }
            return true;
        }

    }

}
