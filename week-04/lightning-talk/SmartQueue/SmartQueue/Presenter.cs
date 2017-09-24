using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartQueue;

namespace Helper
{
    public class Presenter
    {
        public static void PrintStatusForQueue(SmartQueue.SmartQueue myQueue, string eventText)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($" Number of elements after {eventText}: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(myQueue.Count);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($" Elements after {eventText}:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (var item in myQueue)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
