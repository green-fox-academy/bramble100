using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Poker;

namespace PokerTest
{
    [TestFixture]
    public class PokerHandTest
    {
        PlayingCard playingCard;
        Random random = new Random();

        [Test]
        public void WhenNullInput()
        {
            string input = null;
            playingCard = new PlayingCard(input);
            Assert.IsFalse(playingCard.IsValid);
        }

        [Test]
        public void WhenEmptyStringInput()
        {
            string input = string.Empty;
            playingCard = new PlayingCard(input);
            Assert.IsFalse(playingCard.IsValid);
        }

        [Test]
        public void WhenOneInvalidCharInputX()
        {
            string input = "X";
            playingCard = new PlayingCard(input);
            Assert.IsFalse(playingCard.IsValid);
        }

        [Test]
        public void WhenOneInvalidArbitraryCharInput()
        {
            string input = Convert.ToChar('a' + random.Next(25)).ToString();
            //string input = Convert.ToChar('a' + 27).ToString();
            playingCard = new PlayingCard(input);
            Assert.IsFalse(playingCard.IsValid);
        }

        [Test]
        public void WhenTwoInvalidChar()
        {
            string input = "xy";
            playingCard = new PlayingCard(input);
            Assert.IsFalse(playingCard.IsValid);
        }

        [Test]
        public void WhenValidCard()
        {
            string input = "2H";
            playingCard = new PlayingCard(input);
            Assert.IsTrue(playingCard.IsValid);
        }

        [Test]
        public void WhenValidCharsInvalidOrder()
        {
            string input = "H2";
            playingCard = new PlayingCard(input);
            Assert.IsFalse(playingCard.IsValid);
        }

        [Test]
        public void WhenValidRankInvalidSuit()
        {
            string input = "2A";
            playingCard = new PlayingCard(input);
            Assert.IsFalse(playingCard.IsValid);
        }

        [Test]
        public void WhenInValidRankValidSuit()
        {
            string input = "xH";
            playingCard = new PlayingCard(input);
            Assert.IsFalse(playingCard.IsValid);
        }

        [Test]
        public void WhenValidCardLowerCase()
        {
            string input = "qh";
            playingCard = new PlayingCard(input);
            Assert.IsTrue(playingCard.IsValid);
        }

        [Test]
        public void WhenSpecialChar()
        {
            string input = "t;";
            playingCard = new PlayingCard(input);
            Assert.IsFalse(playingCard.IsValid);
        }
    }
}
