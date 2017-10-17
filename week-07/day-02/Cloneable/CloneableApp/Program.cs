using HomeWork;
using System;

namespace CloneableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student("John Doe", 20, Gender.Male, "BME");
            Student johnTheClone = (Student) john.Clone();
            john.ToString();
            johnTheClone.Introduce();
            Console.ReadKey();
        }
    }
}
