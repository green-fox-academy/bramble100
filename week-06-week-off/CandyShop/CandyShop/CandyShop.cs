using System;
using System.Collections.Generic;

namespace CandyShopLogic
{
    public class CandyShop : Dictionary<Type, decimal>
    {
        private Dictionary<Type, decimal> pricesOfGoods;

        // We run a Candy shop where we sell candies and lollipops
        // One lollipop's price is 10$
        // And it made from 5gr of sugar
        // One candie's price is 20$
        // And it made from 10gr of sugar
        // we can raise their prices with a given percentage

        // Create a CandyShop class
        // It can store sugar and money as income. The constructor should take the amount of sugar in gramms.
        // we can create lollipops and candies store them in the CandyShop's storage
        // If we create a candie or lollipop the CandyShop's sugar amount gets reduced by the amount needed to create the sweets
        // We can raise the prices of all candies and lollipops with a given percentage
        // We can sell candie or lollipop with a given number as amount
        // If we sell sweets the income will be increased by the price of the sweets and we delete it from the inventory
        // We can buy sugar with a given number as amount. The price of 1000gr sugar is 100$
        // If we buy sugar we can raise the CandyShop's amount of sugar and reduce the income by the price of it.
        // The CandyShop should print properties represented as string in this format:
        // "Inventory: 3 candies, 2 lollipops, Income: 100, Sugar: 400gr"

        public static readonly Candy CANDY = new Candy();
        public static readonly Lollipop LOLLIPOP = new Lollipop();


        public CandyShop(decimal sugarGiven)
        {
            Add(typeof(Money), 0);
            Add(typeof(Sugar), sugarGiven);
            Add(typeof(Candy), 0);
            Add(typeof(Lollipop), 0);
            pricesOfGoods = new Dictionary<Type, decimal>()
            {
                { typeof(Candy), 20m },
                { typeof(Lollipop), 10m },
                { typeof(Sugar), 100m}
            };
        }

        public void CreateSweets(Sweet sweet)
        {
            if (sweet.sugarNeeded < this[typeof(Sugar)])
            {
                this[sweet.GetType()] += 1;
                this[typeof(Sugar)] -= sweet.sugarNeeded;
            }
            else
            {
                Console.WriteLine($"Not enough sugar to create the {sweet.GetType().Name}.");
            };
        }

        public void PrintInfo()
        {
            Console.WriteLine(ToString());
        }

        public void Sell(Sweet sweet, decimal qty)
        {
            if (this[sweet.GetType()] > qty)
            {
                this[sweet.GetType()] -= qty;
                this[typeof(Money)] += pricesOfGoods[sweet.GetType()] * qty;
            }
            else
            {
                Console.WriteLine($"Not enough {sweet.GetType().Name} to sell.");
            };
        }

        public void Raise(decimal raise)
        {
            pricesOfGoods[typeof(Candy)] *= (1 + raise / 100);
            pricesOfGoods[typeof(Lollipop)] *= (1 + raise / 100);
        }

        /// <summary>
        /// Buys the given amount of sugar (amount in gr).
        /// </summary>
        /// <param name="sugar">The amount of sugar in gr</param>
        public void BuySugar(decimal sugar)
        {
            if (sugar / 1000 * pricesOfGoods[typeof(Sugar)] < this[typeof(Money)])
            {
                this[typeof(Sugar)] += sugar;
                this[typeof(Money)] -= sugar / 1000 * pricesOfGoods[typeof(Sugar)];
            }
            else
            {
                Console.WriteLine($"Not enough money to buy {sugar} gr of sugar.");
            }
        }

        public override string ToString() => $"CandyShop: Money: ${this[typeof(Money)]}" +
                $" Sugar: {this[typeof(Sugar)]} gr" +
                $" Candy: {this[typeof(Candy)]} pcs" +
                $" Lollipop: {this[typeof(Lollipop)]} pcs";
    }
}