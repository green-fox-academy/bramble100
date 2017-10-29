using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.ViewModels
{
    public class FoodnDrink
    {
        public string[] Foods => Enum.GetNames(typeof(Models.Food));
        public string[] Drinks => Enum.GetNames(typeof(Models.Drink));
    }
}
