using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer
{
    class Hero : MovingObject
    {
        internal Hero(Dice dice) : base(dice)
        {
        }

        protected void Initialize()
        {
            // HP: 20 + 3 * d6
            MaximalHealthPoints = CurrentHealthPoints = 20 + dice.Roll() + dice.Roll() + dice.Roll();
            // DP: 2 * d6
            DefendPoints = 2 + dice.Roll() + dice.Roll();
            // SP: 5 + d6
            StrikePoints = 5 + dice.Roll();
        }
    }
}