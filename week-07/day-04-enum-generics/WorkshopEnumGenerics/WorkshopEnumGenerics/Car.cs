using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopEnumGenerics
{
    public class Car
    {
        CarColor color;
        CarType type;
        public CarColor Color { get => Color; set => Color = value; }
        public CarType Type { get => type; set => type = value; }

        public Car(CarColor color, CarType type)
        {
            Color = color;
            Type = type;
        }
    }
}