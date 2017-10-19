using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopEnumGenerics.TwentyPlusOne
{
    class Game
    {
        Deck[] decks;
        Hand[] hands;

        public Game(int numberOfDecks = 1, int numberOfHands = 2)
        {
            decks = new Deck[numberOfDecks];
            hands = new Hand[numberOfHands];

            for (int i = 0; i < decks.Length; i++)
            {
                decks[i] = new Deck();
                decks[i].Shuffle();
            }
        }
    }
}
