using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer
{
    class MovingObjects
    {
        Hero hero;
        MonsterBoss monsterBoss;
        KeyHolderMonster keyHolderMonster;
        List<Monster> otherMonsters;
        int MIN_NUMBER_OF_MONSTERS = 3;
        int MAX_NUMBER_OF_MONSTERS = 6;

        internal MovingObjects(Dice dice)
        {
            hero = new Hero(dice);
            monsterBoss = new MonsterBoss(dice);
            keyHolderMonster = new KeyHolderMonster();
            int numberOfMonsters = dice.random.Next(MIN_NUMBER_OF_MONSTERS - 2, MAX_NUMBER_OF_MONSTERS - 1);
            for (int i = 0; i < numberOfMonsters; i++)
            {
                otherMonsters.Add(new Monster(dice));
            }
        }
    }
}
