using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer
{
    class Area : List<Tile>
    {
        const int XSIZE = 10;
        const int YSIZE = 10;
        MovingObjects movingObjects;
        int totalNumberOfMonsters;
        int Level;
        int MIN_NUMBER_OF_MONSTERS = 3;
        int MAX_NUMBER_OF_MONSTERS = 6;

        Dice Dice;

        public Area(int level, Dice dice)
        {
            Dice = dice;
            Level = level;
            totalNumberOfMonsters = dice.random.Next(MIN_NUMBER_OF_MONSTERS - 2, MAX_NUMBER_OF_MONSTERS - 1);
            movingObjects = new MovingObjects(totalNumberOfMonsters, level, dice);
            AddRange(LayoutGenerator());
            RandomLayoutGenerator();
        }

        internal List<Tile> LayoutGenerator()
        {
            List<bool> isWalkableList = new List<bool>()
            {
                true, true, true, false, true, false, true, true, true, true,
                true, true, true, false, true, false, true, false, false, true,
                true, false, false, false, true, false, true, false, false, true,
                true, true, true, true, true, false, true, true, true, true,
                false, false, false, false, true, false, false, false, false, true,
                true, false, true, false, true, true, true, true, false, true, 
                true, false, true, false, true, false, false, true, false, true, 
                true, true, true, true, true, false, false, true, false, true, 
                true,false, false, false, true, true, true, true, false, true, 
                true, true, true, false, true, false, false, true, false, true, 
                true, false, true, false, true, false, true, true, true, true
            };
            List<Tile> layout = new List<Tile>();
            isWalkableList.ForEach(isWalkable => layout.Add(new Tile(isWalkable)));
            return layout;
        }

        public void RandomLayoutGenerator()
        {
            throw new NotImplementedException();
        }
    }
}
