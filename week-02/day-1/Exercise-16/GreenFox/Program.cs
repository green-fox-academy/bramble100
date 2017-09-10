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
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
            // It should print how many legs all the animals have

            Console.WriteLine("How many chicken?");
            string numberOfChickens = Console.ReadLine();
            Console.WriteLine("How many pigs?");
            string numberOfPigs = Console.ReadLine();
            Console.WriteLine("Number of legs: " + (Int64.Parse(numberOfChickens) * 2 + Int64.Parse(numberOfPigs) * 4));


            Console.ReadKey();
        }
    }
}
