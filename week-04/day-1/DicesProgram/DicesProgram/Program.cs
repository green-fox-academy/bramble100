using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicesProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Dices dices = new Dices(new Random());
            Console.WriteLine(dices.ToString());
            ConsoleKeyInfo key = Console.ReadKey();
            while(key.Key != ConsoleKey.Escape)
            {
                dices.Roll();
                 Console.WriteLine(dices.ToString());
                key = Console.ReadKey();
            }
        }
    }
}
