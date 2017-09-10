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
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was
            Console.WriteLine("Enter a number, please:");
            int number = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < number+1; i++)
            {
                Console.WriteLine(String.Concat(Enumerable.Repeat("*", i)));
            }
            Console.ReadKey();
        }
    }
}
