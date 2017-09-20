using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JosephusProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3; i < 42; i++)
            {
                Console.WriteLine("{0}: {1}", i, FindSurvivorSeat(i));
            }
            Console.ReadKey();
        }

        private static int FindSurvivorSeat(int numberOfParticipants)
        {
            // value: original pos
            var gamers = new Queue<int>(Enumerable.Range(1, numberOfParticipants));
            while (gamers.Count > 1)
            {
                gamers.Enqueue(gamers.Dequeue());
                gamers.Dequeue();
            }
            return gamers.Dequeue();
        }
    }
}