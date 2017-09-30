using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer
{
    class Monster : MovingObject
    {
        internal Monster(int level, Dice dice) : base(dice)
        {
            // Monster Lvl x
            // HP: 2 * x * d6
            MaximalHealthPoints = CurrentHealthPoints = 2 * level * dice.Roll();
            // DP: x / 2 * d6
            DefendPoints = level / 2 * dice.Roll() + dice.Roll();
            // SP: x* d6
            StrikePoints = level * dice.Roll();
        }
    }
}
