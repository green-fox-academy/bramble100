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
        Hand player;
        public bool IsOver;
        public bool IsWonByDealer;

        public bool IsPush => dealer.IsBlackJack && player.IsBlackJack;

        public bool IsWonByPlayerWithBlackJack => player.IsBlackJack;

        public bool IsWonByDealerWithBlackJack => dealer.IsBlackJack;

        public Game()
        {
            deck = new Deck();
            dealer = new Hand();
            player = new Hand();
            IsOver = false;

            deck.Shuffle();

        }

        public void Play()
        {
            PlayerDecision playerDecision;

            FirstDeal();
            ToString();
            if (IsWonByPlayerWithBlackJack || IsWonByDealerWithBlackJack)
            {
                IsOver = true;
                return;
            }

            do
            {
                playerDecision = GetPlayerDecision();
                if (playerDecision == PlayerDecision.Hit)
                {
                    Hit();
                }
            } while (playerDecision == PlayerDecision.Hit);
            IsOver = true;
        }

        private PlayerDecision GetPlayerDecision()
        {
            ConsoleKeyInfo key;

            Console.WriteLine("What is your decision?");
            Console.WriteLine("(H)it / (S)tand");
            do
            {
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.H || key.Key != ConsoleKey.S);

            if (key.Key != ConsoleKey.H)
            {
                return PlayerDecision.Hit;
            }

            return PlayerDecision.Stand;
        }

        private void Hit()
        {
            Deal(player);
        }

        private void FirstDeal()
        {
            for (int cardTurn = 0; cardTurn < 2; cardTurn++)
            {
                Deal(player);
                Deal(dealer);
            }
        }

        private void Deal(int playerIndex)
            => player.Add(deck.PullFirst());

        private void Deal(Hand hand)
            => dealer.Add(deck.PullFirst());

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("BlackJack game.");
            stringBuilder.AppendLine($"The game is {(IsOver ? String.Empty : "not ")}over.");
            stringBuilder.AppendLine("Dealer's hand:");
            stringBuilder.AppendLine(dealer.ToString());
            stringBuilder.AppendLine("Player's hand:");
            stringBuilder.AppendLine(player.ToString());
            return stringBuilder.ToString();
        }
    }
}