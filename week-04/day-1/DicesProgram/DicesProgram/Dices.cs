using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicesProgram
{
    class Dices : List<Dice>
    {
        private Random random;
        private int NumberOfDices = 6;

        public Dices(Random random)
        {
            for (int i = 0; i < 6; i++)
            {
                this.Add(new Dice(random));
            }
        }

        public void Roll()
        {
            foreach (var dice in this)
            {
                dice.Roll();
            }
        }

        public int[] ActualValues()
        {
            int[] values = new int[NumberOfDices];
            for (int i = 0; i < this.Count; i++)
            {
                values[i] = this[i].GetValue();
            }
            return values;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("The dices are:");
            for (int i = 0; i < Count; i++)
            {
                stringBuilder.Append($" {this[i].GetValue()}");
            }
            return stringBuilder.ToString();
        }
    }
}
