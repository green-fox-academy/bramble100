using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalculatorEngine
    {
        public string originalString;
        private string stringToCalculate;
        List<string> calculatorStringList;
        string validDigits = "0123456789.";
        string validOperators = "*/+-";

        public CalculatorEngine(string inputStringToCalculate)
        {
            calculatorStringList = new List<string>();
            Feed(inputStringToCalculate);
        }
        public void Feed(string inputStringToCalculate)
        {
            originalString = inputStringToCalculate;
            if (IsValid(inputStringToCalculate))
            {
                stringToCalculate = inputStringToCalculate;
            }
            Parse();
        }

        internal double PerformCalculation()
        {
            int cursor;
            foreach (var op in validOperators.ToArray())
            {
                cursor = FindNextOperator(0, op);
                while (cursor != 0)
                {
                    CalculateNextOperation(cursor, op);
                    cursor = FindNextOperator(cursor, op);
                }
                DisplaycalculatorStringList();
            }
            return Double.Parse(calculatorStringList.First());
        }

        private void DisplaycalculatorStringList()
        {
            foreach (var item in calculatorStringList)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        private void CalculateNextOperation(int localCursor, char op)
        {
            double number1 = Double.Parse(calculatorStringList[localCursor - 1]);
            double number2 = Double.Parse(calculatorStringList[localCursor + 1]);
            if (op == '*')
            {
                calculatorStringList[localCursor - 1] = (number1 * number2).ToString();
            }
            else if (op == '/')
            {
                calculatorStringList[localCursor - 1] = (number1 / number2).ToString();
            }
            else if (op == '+')
            {
                calculatorStringList[localCursor - 1] = (number1 + number2).ToString();
            }
            else if (op == '-')
            {
                calculatorStringList[localCursor - 1] = (number1 - number2).ToString();
            }
            if (calculatorStringList.Count > localCursor + 1)
            {
                calculatorStringList.RemoveRange(localCursor, 2);
            }
        }
        private int FindNextOperator(int startPosition, char op)
        {
            for (int i = startPosition; i < calculatorStringList.Count; i++)
            {
                if (calculatorStringList[i] == op.ToString())
                {
                    return i;
                }
            }
            return 0;
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
        private void ParseWithSpaces()
        {
            calculatorStringList = new List<string>(stringToCalculate.Split(' '));
        }

        private void Parse()
        {
            string actualNumberString = "";
            stringToCalculate = stringToCalculate.Replace(" ", String.Empty);

            for (int i = 0; i < stringToCalculate.Length; i++)
            {
                if (validDigits.Contains(stringToCalculate[i]))
                {
                    actualNumberString += stringToCalculate[i];
                }
                else if (validOperators.Contains(stringToCalculate[i]))
                {
                    calculatorStringList.Add(actualNumberString);
                    actualNumberString = "";
                    calculatorStringList.Add(stringToCalculate[i].ToString());
                }
            }

            if(actualNumberString != "")
            {
                calculatorStringList.Add(actualNumberString);
            }
        }
    }
}
