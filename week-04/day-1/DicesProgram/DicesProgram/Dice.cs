using System;

namespace DicesProgram
{
    internal class Dice
    {
        private int value;

        private Random Random;

        public int Value { get => value; private set => Value = value; }

        public Dice(Random random)
        {
            this.Random = random;
            Roll();
        }

        public void Roll() => value = Random.Next(1, 7);
    }
}