using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wanderer
{
    class Battle
    {
        MovingObject Attacker;
        MovingObject Defendant;

        public Battle(MovingObject attacker, MovingObject defendant)
        {
            Attacker = attacker;
            Defendant = defendant;
        }

        public void Perform()
        {
            while(Attacker.IsAlive && Defendant.IsAlive)
            {
                Attacker.Strike(Defendant);
                Defendant.Strike(Attacker);
            }
        }
    }
}
