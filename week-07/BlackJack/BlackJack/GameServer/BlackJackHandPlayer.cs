using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.GameServer
{
    public class BlackJackHandPlayer : Hand
    {
        public BlackJackHandPlayer()
        {
        }

        public BlackJackHandPlayer(HashSet<Card> cards) : base(cards)
        {
        }

        public bool IsImprovable => !IsBusted;
    }
}