using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day03BankOfSimba.Models
{
    public class AnimalTypeClassification : Dictionary<AnimalType, GuyClassification>
    {
        public AnimalTypeClassification()
        {
            Add(AnimalType.Cobra, GuyClassification.BadGuy);
            Add(AnimalType.KingLion, GuyClassification.GoodGuy);
            Add(AnimalType.Lion, GuyClassification.GoodGuy);
            Add(AnimalType.Mandrill, GuyClassification.GoodGuy);
            Add(AnimalType.Meerkat, GuyClassification.BadGuy);
            Add(AnimalType.Warthog, GuyClassification.BadGuy);
        }
    }
}
