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
                Console.WriteLine("{0}: {1}", i, FindSurvivorSeat_WithQueue(i));
            }
            Console.ReadKey();
        }

        private static int FindSurvivorSeat_WithList(int numberOfParticipants)
        {
            // value: original pos
            var gamers = new List<int>(Enumerable.Range(1, numberOfParticipants));
            while (gamers.Count > 1)
            {
                gamers.RemoveAt(1); // second gets killed
                gamers.Add(gamers.First()); // first goes at the end
                gamers.RemoveAt(0); // first goes at the end
            }
            return gamers.First();
        }

        private static int FindSurvivorSeat_WithQueue(int numberOfParticipants)
        {
            var gamers = new Queue<int>(Enumerable.Range(1, numberOfParticipants));
            while (gamers.Count > 1)
            {
                gamers.Enqueue(gamers.Dequeue()); // first goes at the end
                gamers.Dequeue(); // second gets killed
            }
            return gamers.First();
        }
    }
}