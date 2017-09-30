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

        internal MovingObjects(int totalNumberOfMonsters, Dice dice)
        {
            hero = new Hero(dice);
            monsterBoss = new MonsterBoss(dice);
            keyHolderMonster = new KeyHolderMonster();
            for (int i = 2; i < totalNumberOfMonsters; i++)
            {
                otherMonsters.Add(new Monster(dice));
            }
        }
    }
}
