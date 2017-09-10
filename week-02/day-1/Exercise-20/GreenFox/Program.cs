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
            // Write a program that asks for two numbers and prints the bigger one

            Console.WriteLine("Enter an integer (then hit Enter):");
            long number1 = Int64.Parse(Console.ReadLine());

            Console.WriteLine("Enter an integer (then hit Enter):");
            long number2 = Int64.Parse(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine("They are equal");
            }
            else if (number1 > number2)
            {
                Console.WriteLine(number1 + " is bigger than " + number2);
            }
            else
            {
                Console.WriteLine(number1 + " is smaller than " + number2);
            }
            Console.ReadKey();
        }
    }
}
