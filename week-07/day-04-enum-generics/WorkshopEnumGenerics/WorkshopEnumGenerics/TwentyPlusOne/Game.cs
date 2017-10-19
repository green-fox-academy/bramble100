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
        public bool IsWonByDealer;

        public bool IsPush => dealer.IsBlackJack && players[0].IsBlackJack;

        public bool IsWonByPlayerWithBlackJack => players[0].IsBlackJack;

        public bool IsWonByDealerWithBlackJack => dealer.IsBlackJack;

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
            ToString();
            if (IsWonByPlayerWithBlackJack || IsWonByDealerWithBlackJack)
            {
                IsOver = true;
                return;
            }

            for (int player = 0; player < players.Length; player++)
            {
                GetPlayerDecision(player);
            }
            IsOver = true;
        }

        private void GetPlayerDecision(int player)
        {
            ConsoleKeyInfo key;

            Console.WriteLine("What is your decision?");
            Console.WriteLine("(H)it / (S)tand");
            do
            {
                key = Console.ReadKey();
                if (key.Key != ConsoleKey.H)
                {
                    Hit(player);
                }

            } while (key.Key != ConsoleKey.H || key.Key != ConsoleKey.S);
        }

        private void Hit(int player)
        {
            throw new NotImplementedException();
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

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("BlackJack game.");
            stringBuilder.AppendLine($"Number of players: {players.Length}");
            stringBuilder.AppendLine($"The game is {(IsOver ? String.Empty : "not ")}over.");
            stringBuilder.AppendLine("Dealer's hand:");
            stringBuilder.AppendLine(dealer.ToString());
            stringBuilder.AppendLine("Player's hand:");
            stringBuilder.AppendLine(players[0].ToString());
            return stringBuilder.ToString();
        }
    }
}