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
            MyCalculator Calc = new MyCalculator(testString);
            MyCalculator(testString);
            Console.ReadKey();
        }

        static double MyCalculator(string CalculatorString)
        {
            string[] operators = { "*", "/", "+", "-" };
            List<string> calculatorStringList = new List<string>(CalculatorString.Split(' '));
            int cursor;
            foreach (var op in operators)
            {
                cursor = FindNextOperator(0, op);
                while (cursor != 0)
                {
                    CalculateNextOperation(cursor, op);
                    DisplaycalculatorStringList();
                    cursor = FindNextOperator(cursor, op);
                }
            }
            DisplaycalculatorStringList();
            return Double.Parse(calculatorStringList.First());

            int FindNextOperator(int startPosition, string op)
            {
                for (int i = startPosition; i < calculatorStringList.Count; i++)
                {
                    if (calculatorStringList[i] == op)
                    {
                        return i;
                    }
                }
                return 0;
            }

            void CalculateNextOperation(int localCursor, string op)
            {
                double number1 = Double.Parse(calculatorStringList[localCursor - 1]);
                double number2 = Double.Parse(calculatorStringList[localCursor + 1]);
                if (op == "*")
                {
                    calculatorStringList[localCursor - 1] = (number1 * number2).ToString();
                }
                else if (op == "/")
                {
                    calculatorStringList[localCursor - 1] = (number1 / number2).ToString();
                }
                else if (op == "+")
                {
                    calculatorStringList[localCursor - 1] = (number1 + number2).ToString();
                }
                else if (op == "-")
                {
                    calculatorStringList[localCursor - 1] = (number1 - number2).ToString();
                }
                if (calculatorStringList.Count > localCursor + 1)
                {
                    calculatorStringList.RemoveRange(localCursor, 2);
                }
            }

            void DisplaycalculatorStringList()
            {
                foreach (var item in calculatorStringList)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
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
