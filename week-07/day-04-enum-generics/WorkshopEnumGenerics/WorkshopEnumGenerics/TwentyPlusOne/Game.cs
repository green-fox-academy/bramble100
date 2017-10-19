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
        Hand dealer;
        Hand[] players;

        public Game(int numberOfDecks = 1, int numberOfHands = 2)
        {
            decks = new Deck[numberOfDecks];
            dealer = new Hand();
            players = new Hand[numberOfHands];

            for (int i = 0; i < decks.Length; i++)
            {
                decks[i] = new Deck();
                decks[i].Shuffle();
            }
        }

        public override string ToString()
        {
            return "BlackJack game."
                + $"\nNumber of decks: {decks.Length}"
                + $"\nNumber of players: {players.Length}";
        }
    }
}
