using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1634;
            Console.WriteLine("{0} is {1}an Armstrong number.", number, IsArmstrongNumber(number) ? "" : "NOT ");
            number = 153;
            Console.WriteLine("{0} is {1}an Armstrong number.", number, IsArmstrongNumber(number) ? "" : "NOT ");
            Console.ReadKey();
        }

        private static bool IsArmstrongNumber(int number)
        {
            int numberOfDigits = number.ToString().Length;
            int result = 0;
            int actualTenDivider = (int)Math.Pow(10, numberOfDigits-1);
            int originalNumber = number;
            int actualDigit;
            for (int i = 0; i < numberOfDigits; i++)
            {
                actualDigit = (number / actualTenDivider);
                result += (int)Math.Pow(actualDigit, numberOfDigits);
                number %= actualTenDivider;
                actualTenDivider /= 10;
            }
            return result == originalNumber;
        }
    }
}
