using System;
using System.Collections.Generic;

namespace BlackJack.GameServer
{
    public class GameModel : IBlackJackGameModel
    {
        private Deck deck;
        private BlackJackHandDealer dealer;
        private BlackJackHandPlayer player;

        public GameModel()
        {
            dealer = new BlackJackHandDealer();
            player = new BlackJackHandPlayer();
            deck = new Deck();
        }

        public GameModel(Deck deck, 
            BlackJackHandDealer dealer, 
            BlackJackHandPlayer player)
        {
            this.deck = deck ?? throw new ArgumentNullException(nameof(deck));
            this.dealer = dealer ?? throw new ArgumentNullException(nameof(dealer));
            this.player = player ?? throw new ArgumentNullException(nameof(player));
        }

        public HashSet<Card> PlayerHand => player.Cards;
        public int PlayerHandValue => player.Value;
        public HashSet<Card> DealerHand => dealer.Cards;
        public int DealerHandValue => dealer.Value;

        public bool FirstDealHasDone => dealer.Cards.Count > 0
                && player.Cards.Count > 1;
        public bool DealerHandIsImprovable => dealer.IsImprovable && !DealerIsBusted;
        public bool PlayerHandIsImprovable => player.IsImprovable && !PlayerIsBusted;
        public bool DealerHasHigherScore => dealer.Value > player.Value;
        public bool PlayerHasHigherScore => player.Value > dealer.Value;
        public bool IsTied => player.Value == dealer.Value;

        public bool PlayerIsBusted => player.IsBusted;
        public bool DealerIsBusted => dealer.IsBusted;

        public void DealForPlayer() => Deal(player);
        public void DealForDealer() => Deal(dealer);
        private void Deal(Hand hand) => hand.Add(deck.PullFirst());

        public void ShuffleDeck() => deck.Shuffle();

        public string DealerToString() => dealer.ToString();
        public string PlayerToString() => player.ToString();
    }
}