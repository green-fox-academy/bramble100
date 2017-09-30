using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer
{
    class Area : List<Tile>
    {
        const int  XSIZE = 10;
        const int  YSIZE = 10;
        MovingObjects movingObjects;
        int totalNumberOfMonsters;
        int level;
        int MIN_NUMBER_OF_MONSTERS = 3;
        int MAX_NUMBER_OF_MONSTERS = 6;

        Dice dice;

        public Area(int level, Random random)
        {
            totalNumberOfMonsters = dice.random.Next(MIN_NUMBER_OF_MONSTERS - 2, MAX_NUMBER_OF_MONSTERS - 1);
            movingObjects = new MovingObjects(totalNumberOfMonsters, level, dice);
            RandomLayoutGenerator();
        }

        public void RandomLayoutGenerator()
        {
            throw new NotImplementedException();
        }
    }
}
