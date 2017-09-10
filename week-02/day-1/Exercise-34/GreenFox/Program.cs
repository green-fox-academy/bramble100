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
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("How many integers would you like to process? (not more than 255)");
            byte numberOfIntegers = byte.Parse(Console.ReadLine());
            long sumOfIntegers = 0;

            for( int i=1; i<numberOfIntegers+1; i++)
            {
                Console.WriteLine("Enter integer #" + i);
                int actualInteger = Int32.Parse(Console.ReadLine());
                sumOfIntegers += actualInteger;
            }
            Console.WriteLine("The sum of the entered {0} integer(s) is {1}, the average is {2:f}",
                numberOfIntegers,
                sumOfIntegers,
                (float)sumOfIntegers / numberOfIntegers);
            Console.ReadKey();
        }
    }
}
