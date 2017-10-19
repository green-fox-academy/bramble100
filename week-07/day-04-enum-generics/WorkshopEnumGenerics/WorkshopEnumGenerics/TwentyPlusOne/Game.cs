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

        public bool IsPush
        {
            get
            {
                return dealer.IsBlackJack && players[0].IsBlackJack;
            }
        }

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
            if (IsPush)
            {
                IsOver = true;
            }
            if (IsWonWithBlackJack())
            {
                IsOver = true;
            }

            for (int i = 0; i < players.Length; i++)
            {

            }
            IsOver = true;
        }

        private void FirstDeal()
        {
            for (int cardTurn = 0; cardTurn < 2; cardTurn++)
            {
                for (int player = 0; player < players.Length; player++)
                {
                    Deal(player);
                }
                Deal(dealer);
            }
        }

        private void Deal(int playerIndex) 
            => players[playerIndex].Add(deck.PullFirst());

        private void Deal(Hand hand) 
            => dealer.Add(deck.PullFirst());

        private bool IsWonWithBlackJack()
        {
            return players[0].IsBlackJack;
        }

        public override string ToString()
        {
            return "BlackJack game."
                + $"\nNumber of players: {players.Length}"
                + $"\nThe game is {(IsOver ? String.Empty : "not ")}over.";
        }
    }
}