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
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            int remainingSeconds = 24 * 60 * 60;
            remainingSeconds -= currentHours * 60 * 60;
            remainingSeconds -= currentMinutes * 60;
            remainingSeconds -= currentSeconds;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented bt the variables

            Console.WriteLine("Remaining time: " + remainingSeconds + " second(s)");
            Console.ReadKey();
        }
    }
}
