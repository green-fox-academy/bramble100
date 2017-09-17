using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysLife
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            Universe Universe = new Universe();
            Universe.Display();
            key = Console.ReadKey();
            while (key.Key != ConsoleKey.Escape)
            {
                Universe.Update();
                Universe.Display();
                key = Console.ReadKey();
            }
        }
    }

    public class Universe
    {
        bool[,] universe;

        public Universe(int width = 100, int height = 30, bool randomFill = true, int randomRatio = 30)
        {
            universe = new bool[height, width];
            Random random = new Random();
            if (randomFill)
            {
                for (int h = 0; h < height; h++)
                {
                    for (int w = 0; w < width; w++)
                    {
                        universe[h, w] = random.Next(100) < randomRatio;
                    }
                }
            }
        }

        internal void Display()
        {
            Console.Clear();
            for (int height = 0; height < universe.GetLength(0); height++)
            {
                for (int width = 0; width < universe.GetLength(1); width++)
                {
                    Console.Write(universe[height, width] ? "X" : " ");
                }
                Console.WriteLine();
            }
        }

        internal void Update()
        {
            bool[,] futureUniverse = new bool[universe.GetLength(0), universe.GetLength(1)];

            for (int height = 0; height < universe.GetLength(0); height++)
            {
                for (int width = 0; width < universe.GetLength(1); width++)
                {
                    byte numberOfNeighbors = GetNumberOfNeighbors(height, width);
                    if (universe[height, width])
                    {
                        futureUniverse[height, width] = numberOfNeighbors == 2 || numberOfNeighbors == 3;
                    }
                    else
                    {
                        futureUniverse[height, width] = numberOfNeighbors == 3;
                    }
                }
            }
            for (int height = 0; height < universe.GetLength(0); height++)
            {
                for (int width = 0; width < universe.GetLength(1); width++)
                {
                    universe[height, width] = futureUniverse[height, width];
                }
            }
        }

        private byte GetNumberOfNeighbors(int height, int width)
        {
            byte numberOfNeighbors = 0;

            // N
            if (height > 0)
            {
                numberOfNeighbors += (byte)(universe[height - 1, width] ? 1 : 0);
            }
            // NE
            if (height > 0 && width < universe.GetLength(1) - 1)
            {
                numberOfNeighbors += (byte)(universe[height - 1, width + 1] ? 1 : 0);
            }
            // E
            if (width < universe.GetLength(1) - 1)
            {
                numberOfNeighbors += (byte)(universe[height, width + 1] ? 1 : 0);
            }
            // SE
            if (height < universe.GetLength(0) - 1 && width < universe.GetLength(1) - 1)
            {
                numberOfNeighbors += (byte)(universe[height + 1, width + 1] ? 1 : 0);
            }
            // S
            if (height < universe.GetLength(0) - 1)
            {
                numberOfNeighbors += (byte)(universe[height + 1, width] ? 1 : 0);
            }
            // SW
            if (height < universe.GetLength(0) - 1 && width > 0)
            {
                numberOfNeighbors += (byte)(universe[height + 1, width - 1] ? 1 : 0);
            }
            // W
            if (width > 0)
            {
                numberOfNeighbors += (byte)(universe[height, width - 1] ? 1 : 0);
            }
            // NW
            if (height > 0 && width > 0)
            {
                numberOfNeighbors += (byte)(universe[height - 1, width - 1] ? 1 : 0);
            }

            return numberOfNeighbors;
        }
    }
}
