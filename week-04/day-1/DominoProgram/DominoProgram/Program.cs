using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...
            Console.WriteLine(DominosToString(SortedDominos(dominoes)));
            Console.ReadKey();
        }

        private static string DominosToString(List<Domino> dominos)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Domino domino in dominos)
            {
                stringBuilder.Append($"[{domino.Sides[0]}, {domino.Sides[1]}], ");
            }
            stringBuilder.Remove(stringBuilder.Length - 2, 2);
            return stringBuilder.ToString();
        }

        public static List<Domino> SortedDominos(List<Domino> inputDominos)
        {
            List<Domino> outputDominos = new List<Domino>();
            AddFirstDomino(inputDominos, outputDominos);
            while (inputDominos.Count>0)
            {
                AddNextDomino(inputDominos, outputDominos, SearchNextDomino(inputDominos, outputDominos.Last()));
            }
            return outputDominos;
        }

        private static void AddNextDomino(List<Domino> inputDominos, List<Domino> outputDominos, int counter)
        {
            Domino domino = inputDominos[counter];
            inputDominos.RemoveAt(counter);
            if (outputDominos.Last().Sides[1] == domino.Sides[1])
            {
                int temp = domino.Sides[0];
                domino.Sides[0] = domino.Sides[1];
                domino.Sides[1] = temp;
            }
            outputDominos.Add(domino);
        }

        private static int SearchNextDomino(List<Domino> inputDominos, Domino domino)
        {
            for (int counter = 0; counter < inputDominos.Count; counter++)
            {
                if (inputDominos[counter].Sides[0] == domino.Sides[1] || inputDominos[counter].Sides[1] == domino.Sides[1])
                {
                    return counter;
                }
            }
            throw new Exception("No matching domino found.");
        }

        private static void AddFirstDomino(List<Domino> inputDominos, List<Domino> outputDominos)
        {
            outputDominos.Add(inputDominos.Last());
            inputDominos.RemoveAt(inputDominos.Count - 1);
        }

        public static List<Domino> InitializeDominoes() => new List<Domino>
            {
                new Domino(5, 2),
                new Domino(4, 6),
                new Domino(1, 5),
                new Domino(6, 7),
                new Domino(2, 4),
                new Domino(7, 1)
            };
    }
}
