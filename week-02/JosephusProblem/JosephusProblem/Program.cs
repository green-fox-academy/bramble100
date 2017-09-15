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
            var gamers = new List<int>(Enumerable.Range(1, numberOfParticipants));
            while (gamers.Count > 1)
            {
                gamers.RemoveAt(1);
                gamers.Add(gamers.First());
                gamers.RemoveAt(0);
            }
            return gamers.First();
        }
    }
}