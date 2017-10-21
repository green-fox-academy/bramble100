using NUnit.Framework;
using WorkshopEnumGenerics.TwentyPlusOne;

namespace WorkshopEnumGenericsTests
{
    [TestFixture, TestOf("Game")]
    class GameTests
    {
        [Test]
        public void AfterFirstDealGameGoesOn()
        {
            Game game = new Game();
            game.dealer.Add(new Card(Rank.Eight, Suit.Hearts));
            game.dealer.Add(new Card(Rank.Nine, Suit.Hearts));

            game.player.Add(new Card(Rank.Seven, Suit.Clubs));
            game.player.Add(new Card(Rank.Five, Suit.Clubs));

            Assert.False(game.IsEndedAfterFirstDeal);
            Assert.False(game.IsOver);
            Assert.False(game.IsPush);
            Assert.False(game.IsWonByDealer);
            Assert.False(game.IsWonByPlayer);
        }

        [Test]
        public void AfterFirstDealPlayerHasBlackJack()
        {
            Game game = new Game();
            game.dealer.Add(new Card(Rank.Eight, Suit.Hearts));
            game.dealer.Add(new Card(Rank.Nine, Suit.Hearts));

            game.player.Add(new Card(Rank.Ace, Suit.Clubs));
            game.player.Add(new Card(Rank.Jack, Suit.Clubs));

            Assert.True(game.IsEndedAfterFirstDeal);
            Assert.True(game.IsOver);
            Assert.False(game.IsPush);
            Assert.False(game.IsWonByDealer);
            Assert.True(game.IsWonByPlayer);
        }

        [Test]
        public void AfterFirstDealDealerHasBlackJack()
        {
            Game game = new Game();
            game.dealer.Add(new Card(Rank.Ace, Suit.Hearts));
            game.dealer.Add(new Card(Rank.King, Suit.Hearts));

            game.player.Add(new Card(Rank.Six, Suit.Clubs));
            game.player.Add(new Card(Rank.Jack, Suit.Clubs));

            Assert.True(game.IsEndedAfterFirstDeal);
            Assert.True(game.IsOver);
            Assert.False(game.IsPush);
            Assert.True(game.IsWonByDealer);
            Assert.False(game.IsWonByPlayer);
        }

        [Test]
        public void DealerIsBusted()
        {
            Game game = new Game();
            game.dealer.Add(new Card(Rank.Queen, Suit.Hearts));
            game.dealer.Add(new Card(Rank.Nine, Suit.Hearts));
            game.dealer.Add(new Card(Rank.King, Suit.Spades));

            game.player.Add(new Card(Rank.Two, Suit.Clubs));
            game.player.Add(new Card(Rank.Ace, Suit.Diamonds));

            Assert.AreEqual(29, game.dealer.Value);
            Assert.AreEqual(13, game.player.Value);

            Assert.True(game.IsEndedAfterFirstDeal);
            Assert.True(game.IsOver);
            Assert.False(game.IsPush);
            Assert.False(game.IsWonByDealer);
            Assert.True(game.IsWonByPlayer);
        }
    }
}