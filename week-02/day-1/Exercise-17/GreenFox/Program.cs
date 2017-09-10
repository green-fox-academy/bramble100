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
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("Enter five (5) integers in a row (hit Enter between)");

            long[] numbers = new long[5];
            long sum = 0;

            for (byte i = 0; i < 5; i++) 
            {
                numbers[i] = Int64.Parse(Console.ReadLine());
                sum += numbers[i];
            }

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + sum / 5.0);

            Console.ReadKey();
        }
    }
}
