using System;
using System.Text;

namespace WorkshopEnumGenerics.TwentyPlusOne
{
    public class Game
    {

        public bool IsPush
            => dealer.IsBlackJack && player.IsBlackJack;

        public bool IsWonByPlayer
            => player.IsBlackJack || dealer.IsBusted;

        public bool IsWonByDealer
            => dealer.IsBlackJack || player.IsBusted;

        public bool IsEndedAfterFirstDeal
            => IsWonByPlayer || IsWonByDealer;

        public Deck deck;
        public Hand dealer;
        public Hand player;
        public bool IsOver
            => IsPush || IsWonByDealer || IsWonByPlayer;

        public Game()
        {
            deck = new Deck();
            dealer = new Hand();
            player = new Hand();

            deck.Shuffle();
        }

        public void Play()
        {
            FirstDeal();
            Console.WriteLine(ToString());

            if (!IsOver)
            {
                ImproveHands();
            }            
        }

        private void ImproveHands()
        {
            PlayerDecision playerDecision;
            do
            {
                playerDecision = GetPlayerDecision();
                if (playerDecision == PlayerDecision.Hit)
                {
                    Deal(player);
                    Console.WriteLine(ToString());
                }
            } while (playerDecision == PlayerDecision.Hit);
        }

        private PlayerDecision GetPlayerDecision()
        {
            ConsoleKey key;

            Console.WriteLine("What is your decision?");
            Console.WriteLine("(H)it / (S)tand");
            do
            {
                key = Console.ReadKey().Key;
            } while (key != ConsoleKey.H && key != ConsoleKey.S);

            return key == ConsoleKey.H ? PlayerDecision.Hit : PlayerDecision.Stand;
        }

        private void FirstDeal()
        {
            Deal(player);
            Deal(dealer);
            Deal(player);
            Deal(dealer);
        }

        private void Deal(Hand hand)
            => hand.Add(deck.PullFirst());

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