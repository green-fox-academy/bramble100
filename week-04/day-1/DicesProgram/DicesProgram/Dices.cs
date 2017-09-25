using System;
using System.Collections.Generic;
using System.Text;

namespace DicesProgram
{
    class Dices : List<Dice>
    {
        private Random Random;
        private int NumberOfDices = 6;

        public Dices(Random random, int numberOfDices = 6)
        {
            NumberOfDices = numberOfDices;
            Random = random;
            for (int i = 0; i < NumberOfDices; i++)
            {
                Add(new Dice(random));
            }
        }

        public void Roll() => ForEach(dice => dice.Roll());

        public int[] ActualValues()
        {
            List<int> values = new List<int>();
            ForEach(dice => values.Add(dice.Value));
            return values.ToArray();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("The dices are:");
            ForEach(dice => stringBuilder.Append($" {dice.Value}"));
            return stringBuilder.ToString();
        }
    }
}
