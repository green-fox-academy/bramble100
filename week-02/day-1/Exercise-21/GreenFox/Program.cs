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
            // Write a program that asks for two numbers
            // Thw first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people

            Console.WriteLine("How many girls are coming to the party?");
            long numberOfGirls = Int64.Parse(Console.ReadLine());
            if (numberOfGirls == 0)
            {
                Console.WriteLine("Sausage party");
            }
            else
            {
                Console.WriteLine("How many boys are coming to the party?");
                long numberOfBoys = Int64.Parse(Console.ReadLine());

                if (numberOfGirls + numberOfBoys <= 20)
                {
                    Console.WriteLine("Average party...");
                }
                else if (numberOfGirls != numberOfBoys)
                {
                    Console.WriteLine("Quite cool party!");
                }
                else
                {
                    Console.WriteLine("The party is excellent!");
                }
            }
            Console.ReadKey();
        }
    }
}
