using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Models;

namespace FoxClub.HelperDictionaries
{
    public static class HelperDictionary
    {
        public static Dictionary<string, Food> StringToFood = new Dictionary<string, Food>()
        {
            { "Chicken", Food.Chicken },
            { "FishermanSoup", Food.FishermanSoup },
            { "Gulash", Food.Gulash },
            { "Salad", Food.Salad },
            { "Venison", Food.Venison }
        };

        public static Dictionary<string, Drink> StringToDrink = new Dictionary<string, Drink>()
        {
            { "Champagne", Drink.Champagne },
            { "Coke", Drink.Coke },
            { "Lemonade", Drink.Lemonade },
            { "Water", Drink.Water },
            { "Wine", Drink.Wine }
        };

        public static Dictionary<string, Trick> StringToTrick = new Dictionary<string, Trick>()
        {
            { "CatchMouse", Trick.CatchMouse },
            { "ClimbMountains", Trick.ClimbMountains },
            { "CodeInCSharp", Trick.CodeInCSharp },
            { "KillChicken", Trick.KillChicken },
            { "PrettifyWithCSS", Trick.PrettifyWithCSS },
            { "SwimWithDolphins", Trick.SwimWithDolphins },
            { "WriteHTML", Trick.WriteHTML }
        };
    }
}
