using System;

namespace DicesProgram
{
    internal class Dice
    {
        private int Value;

        private Random random;

        public Dice(Random random)
        {
            this.random = random;
            Roll();
        }

        public void Roll()
        {
            Value = random.Next(1, 7);
        }

        public int GetValue()
        {
            return Value;
        }
    }
}