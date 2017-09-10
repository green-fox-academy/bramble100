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
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it
            Console.WriteLine("Enter an integer that is a distance in kilometers:");
            string distanceInKmString = Console.ReadLine();
            long distanceInKm = System.Int64.Parse(distanceInKmString);

            Console.WriteLine("Distance in miles:" + distanceInKm / 1.609);
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
