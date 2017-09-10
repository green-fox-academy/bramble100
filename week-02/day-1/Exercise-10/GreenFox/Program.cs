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
            // Define several things as a variable than print their values
            // Your name as a string
            string name = "Arnold";
            Console.WriteLine("Name: " + name);

            // Your age as an integer
            int age = 42;
            Console.WriteLine("Age: " + age);

            // Your height in meters as a double
            double heightinM = 1.74;
            Console.WriteLine("Height: " + heightinM + " m");
            // Wether you are married or not as a boolean

            Boolean isMarried = false;
            Console.WriteLine("Married: " + isMarried);

            Console.ReadKey();

        }
    }
}
