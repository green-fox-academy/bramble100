using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer
{
    class Monster : MovingObject
    {
        internal Monster(int areaLevel, Dice dice) : base(dice)
        {
            // the monsters levels come from the number of the area
            // if its the Xth area, the mosters have lvl X(with 50 % chance) or lvl X + 1(40 %) or lvl X + 2(10 %)

            Level = areaLevel + LevelModifierCalculator();

            // Monster Lvl x
            // HP: 2 * x * d6
            MaximalHealthPoints = CurrentHealthPoints = 2 * Level * dice.Roll();
            // DP: x / 2 * d6
            DefendPoints = Level / 2 * dice.Roll() + dice.Roll();
            // SP: x* d6
            StrikePoints = Level * dice.Roll();
        }

        private int LevelModifierCalculator()
        {
            int random10 = dice.random.Next(10);
            int modifier = 0; // lower 50 %
            modifier += random10 > 4 ? 1 : 0; // upper 50%
            modifier += random10 > 8 ? 1 : 0; // upper 10%
            return modifier;
        }
    }
}
