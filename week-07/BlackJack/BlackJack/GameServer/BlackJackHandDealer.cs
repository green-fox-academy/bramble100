using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.GameServer
{
    public class BlackJackHandDealer : Hand
    {
        private int DEALER_DECISION_POINT = 17;

        public BlackJackHandDealer() : base()
        {
        }

        public BlackJackHandDealer(HashSet<Card> cards) : base(cards)
        {
        }

        public bool IsImprovable => Value < DEALER_DECISION_POINT;
    }
}