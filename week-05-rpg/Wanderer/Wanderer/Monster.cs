using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer
{
    class Monster : MovingObject
    {
        private int Level;

        protected Monster(Dice dice) : base(dice)
        {
        }

        virtual protected void Initialize(int level = 1)
        {
            // Monster Lvl x(if boss)
            // HP: 2 * x * d6(+d6)
            MaximalHealthPoints = CurrentHealthPoints = 2 * level * dice.Roll();
            // DP: x / 2 * d6(+d6 / 2)
            DefendPoints = level/2 * dice.Roll() + dice.Roll();
            // SP: x* d6(+x)
            StrikePoints = level * dice.Roll();
        }
    }
}
