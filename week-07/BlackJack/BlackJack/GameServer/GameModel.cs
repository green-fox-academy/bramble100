using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.GameServer
{
    class GameModel
    {
        public Deck deck;
        public BlackJackHandDealer dealer;
        public BlackJackHandPlayer player;
        private int playerBet;
    }
}
