using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BlackJack.GameServer;

namespace BlackJackTests
{
    [TestFixture, TestOf("GameModel")]
    class GameModelTests
    {
        [Test]
        public void FirstDealHasDone_IsTrue()
        {
            var blackJackHandDealer = new BlackJackHandDealer(
                new HashSet<Card>()
                { new Card(Rank.Two, Suit.Clubs),
                new Card(Rank.Three, Suit.Clubs)});
            var blackJackHandPlayer = new BlackJackHandPlayer(
                new HashSet<Card>()
                { new Card(Rank.Four, Suit.Clubs),
                new Card(Rank.Five, Suit.Clubs)});

            GameModel gameModel = new GameModel(
                new Deck(new List<Card>(), new Random()),
                blackJackHandDealer,
                blackJackHandPlayer);

            Assert.IsTrue(gameModel.FirstDealHasDone);
        }

        [Test]
        public void FirstDealHasDone_IsFalse_Dealer()
        {
            var blackJackHandDealer = new BlackJackHandDealer(
                new HashSet<Card>());
            var blackJackHandPlayer = new BlackJackHandPlayer(
                new HashSet<Card>()
                { new Card(Rank.Four, Suit.Clubs),
                new Card(Rank.Five, Suit.Clubs)});

            GameModel gameModel = new GameModel(
                new Deck(new List<Card>(), new Random()),
                blackJackHandDealer,
                blackJackHandPlayer);

            Assert.IsFalse(gameModel.FirstDealHasDone);
        }

        [Test]
        public void FirstDealHasDone_IsFalse_Player()
        {
            var blackJackHandDealer = new BlackJackHandDealer(
                new HashSet<Card>()
                { new Card(Rank.Two, Suit.Clubs),
                new Card(Rank.Three, Suit.Clubs)});
            var blackJackHandPlayer = new BlackJackHandPlayer(
                new HashSet<Card>());

            GameModel gameModel = new GameModel(
                new Deck(new List<Card>(), new Random()),
                blackJackHandDealer,
                blackJackHandPlayer);

            Assert.IsFalse(gameModel.FirstDealHasDone);
        }
    }
}
