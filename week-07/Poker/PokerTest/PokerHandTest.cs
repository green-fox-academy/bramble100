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
            string input = Convert.ToChar('a' + random.Next(26)).ToString();
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
    }
}
