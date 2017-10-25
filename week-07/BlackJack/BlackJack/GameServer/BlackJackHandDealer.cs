using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.GameServer
{
    public class BlackJackHandDealer : BlackJackHand
    {
        private int DEALER_DECISION_POINT = 17;

        public bool IsImprovable => value < DEALER_DECISION_POINT;
    }
}