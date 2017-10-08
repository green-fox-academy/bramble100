using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodVsEvil
{
    public class Kata
    {
        /// <summary>
        /// Determines which side wins in the battle.
        /// https://www.codewars.com/kata/52761ee4cffbc69732000738/train/csharp
        /// </summary>
        /// <param name="good"></param>
        /// <param name="evil"></param>
        /// <returns></returns>
        public static string GoodVsEvil(string good, string evil)
        {
            int[] GoodWarriorsWorth = new int[6]
            {
                1, // Hobbits
                2, // Men
                3, // Elves
                3, // Dwarves
                4, //Eagles
                10  // Wizards
            };

            int[] EvilWarriorsWorth = new int[7]
            {
                1, // Orcs
                2, // Men
                2, // Wargs
                2, // Goblins
                3, // Eagles
                5, // Trolls
                10  // Wizards
            };

            int SumOfGoodWarriorsWorth = 0;
            //good.Split(' ').Select((numberOfWarriors, index)
            //    => SumOfGoodWarriorsWorth += Convert.ToInt32(numberOfWarriors) * GoodWarriorsWorth[index]);

            for (int i = 0; i < good.Split(' ').Length; i++)
            {
                SumOfGoodWarriorsWorth += Convert.ToInt32(good.Split(' ')[i]) * GoodWarriorsWorth[i];
            }

            int SumOfEvilWarriorsWorth = 0;
            for (int i = 0; i < evil.Split(' ').Length; i++)
            {
                SumOfEvilWarriorsWorth += Convert.ToInt32(evil.Split(' ')[i]) * EvilWarriorsWorth[i];
            }

            if (SumOfGoodWarriorsWorth > SumOfEvilWarriorsWorth)
            {
                return "Battle Result: Good triumphs over Evil";
            }
            else if (SumOfGoodWarriorsWorth < SumOfEvilWarriorsWorth)
            {
                return "Battle Result: Evil eradicates all trace of Good";
            }
            return "Battle Result: No victor on this battle field";
        }
    }
}
