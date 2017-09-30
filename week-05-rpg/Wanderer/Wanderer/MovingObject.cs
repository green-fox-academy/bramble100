using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer
{
    abstract class MovingObject
    {
        protected int XPosition;
        protected int YPosition;
        protected int MaximalHealthPoints;
        protected int CurrentHealthPoints;
        protected int DefendPoints;
        protected int StrikePoints;

        protected Dice dice;

        public MovingObject(Dice dice) => this.dice = dice;
    }
}
