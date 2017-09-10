using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints a few operations on two numbers: 22 and 13

            // Print the result of 13 added to 22
            Console.WriteLine(22 + 13);

            // Print the result of 13 substracted from 22
            Console.WriteLine(22 - 13);

            // Print the result of 22 mutiplied by 13
            Console.WriteLine(22 * 13);

            // Print the result of 22 divided by 13 (as a decimal fraction)
            Console.WriteLine(22.0 / 13.0);

            // Print the integer part of 22 divided by 13
            Console.WriteLine(22 / 13);

            // Print the reminder of 22 divided by 13
            Console.WriteLine(22 % 13);

            Console.ReadKey();
        }
    }
}
