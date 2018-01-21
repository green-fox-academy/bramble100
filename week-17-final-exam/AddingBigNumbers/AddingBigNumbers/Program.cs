using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AddingBigNumbers
{
    public class Program
    {
        // https://www.codewars.com/kata/adding-big-numbers
        // Write a function that returns the sum of two numbers. 
        // The input numbers are strings and the function must return a string.

        // The input numbers are big
        // The input is a string of only digits
        // The numbers are positives

        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 4_000_000; i++)
            {
                AddStrings("11111111", "222222");
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
            Console.ReadKey();
        }

        public static string AddStrings(string number1String, string number2String)
        {
            if (String.IsNullOrEmpty(number1String))
            {
                return number2String;
            }
            else if (String.IsNullOrEmpty(number2String))
            {
                return number1String;
            }

            int expectedResultLength = number1String.Length;
            expectedResultLength =
                number2String.Length > expectedResultLength ?
                number2String.Length :
                expectedResultLength;
            expectedResultLength++;

            int[] number1Array = ZeroPaddedArray(number1String, expectedResultLength);
            int[] number2Array = ZeroPaddedArray(number2String, expectedResultLength);
            int[] reverseResultArray = AddArrays(number1Array, number2Array);
            int[] resultArray = ReversedArray(reverseResultArray);

            //return String.Join("", resultArray);

            StringBuilder sb = new StringBuilder();
            foreach (var item in resultArray)
            {
                sb.Append(item);
            }
            return sb.ToString();

            //char[] result = new char[expectedResultLength];
            ////var offset = Convert.ToInt16('0');
            //for (int i = 0; i < resultArray.Length; i++)
            //{
            //    result[i] = Convert.ToChar(resultArray[i]);
            //}
            //return Convert.ToString(result);
        }

        public static int[] ZeroPaddedArray(string numberString, int length)
        {
            var numberArray = new int[length];
            var offset = Convert.ToInt32('0');
            for (int i = 0; i < numberString.Length; i++)
            {
                //numberArray[i] = Int32.Parse(Convert.ToString(numberString[numberString.Length - i - 1]));
                numberArray[i] = numberString[numberString.Length - i - 1] - offset;
            }
            for (int i = numberString.Length; i < length; i++)
            {
                numberArray[i] = 0;
            }

            return numberArray;
        }

        public static int[] AddArrays(int[] number1Array, int[] number2Array)
        {
            var resultArray = new int[number1Array.Length];
            int carry = 0;

            for (int i = 0; i < number1Array.Length; i++)
            {
                resultArray[i] = (number1Array[i] + number2Array[i] + carry) % 10;
                carry = number1Array[i] + number2Array[i] + carry > 9 ? 1 : 0;
            }

            return resultArray;
        }

        public static int[] ReversedArray(int[] inputArray)
        {
            int length = inputArray.Length;
            var resultArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                resultArray[i] = inputArray[length - i - 1];
            }

            return resultArray;
        }
    }
}
