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
            // square like this:
            //
            //
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was
            Console.WriteLine("Enter a number, please:");
            int number = Int32.Parse(Console.ReadLine());

            Console.WriteLine(String.Concat(Enumerable.Repeat("%", number)));
            for (int i = 0; i < number - 2; i++)
            {
                Console.WriteLine("%"
                    + String.Concat(Enumerable.Repeat(" ", i))
                    + "%"
                    + String.Concat(Enumerable.Repeat(" ", number -3 - i))
                    + "%");
            }
            Console.WriteLine(String.Concat(Enumerable.Repeat("%", number)));

            Console.ReadKey();

        }
    }
}
