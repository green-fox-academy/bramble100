using System;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci");
            Console.WriteLine(String.Join(" ", RDI.Fibonacci.Numbers()));
            Console.ReadKey();
        }
    }
}
