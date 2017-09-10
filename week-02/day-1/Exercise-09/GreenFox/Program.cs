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
            double massInKg = 81.2;
            double heightInM = 1.78;
            Console.WriteLine("Mass is: " + massInKg + " kg");
            Console.WriteLine("Height is: " + heightInM + " m");
            Console.WriteLine("BMI is: " + massInKg / heightInM / heightInM);
            Console.ReadKey();
        }
    }
}
