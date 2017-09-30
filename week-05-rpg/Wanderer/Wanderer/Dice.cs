using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer
{
    class Dice
    {
        Random random;
        public Dice(Random random)
        {
            this.random = random;
        }

        public int Roll() => random.Next(1, 7);
    }
}
