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
            // Write a program that reads a number form the standard input,
            // Than prints "Odd" if the number is odd, or "Even" it it is even.
            Console.WriteLine("Enter an integer (then hit Enter):");
            Console.WriteLine(Int64.Parse(Console.ReadLine()) % 2 == 0 ? "Even" : "Odd");
            Console.ReadKey();
        }
    }
}