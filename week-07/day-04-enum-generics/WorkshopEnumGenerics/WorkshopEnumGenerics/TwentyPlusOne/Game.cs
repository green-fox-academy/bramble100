using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopEnumGenerics.TwentyPlusOne
{
    class Game
    {
        Deck deck;
        Hand dealer;
        Hand[] players;
        public bool IsOver;

        public Game(int numberOfHands = 1)
        {
            deck = new Deck();
            dealer = new Hand();
            players = new Hand[numberOfHands];
            IsOver = false;

            deck.Shuffle();

            for (int i = 0; i < numberOfHands; i++)
            {
                players[i] = new Hand();
            }
        }

        public void Play()
        {
            FirstDeal();
            if (IsWonWithBlackJack())
            {
                IsOver = true;
            }
        }

        private bool IsWonWithBlackJack()
        {
            return players[0].IsBlackJack;
        }

        private void FirstDeal()
        {
            Deal(dealer, 2);
            for (int i = 0; i < players.Length; i++)
            {
                Deal(i, 2);
            }
        }

        private void Deal(int playerIndex, int numberOfCards)
        {
            for (int i = 0; i < numberOfCards; i++)
            {
                players[playerIndex].Add(deck.PullFirst());
            }
        }

        private void Deal(Hand hand, int numberOfCards)
        {
            for (int i = 0; i < numberOfCards; i++)
            {
                dealer.Add(deck.PullFirst());
            }
        }

        public override string ToString()
        {
            return "BlackJack game."
                + $"\nNumber of players: {players.Length}"
                + $"\nThe game is {(IsOver ? String.Empty : "not ")}over.";
        }
    }
}