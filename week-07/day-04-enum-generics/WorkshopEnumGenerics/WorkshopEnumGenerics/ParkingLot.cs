using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopEnumGenerics
{
    public class ParkingLot
    {
        int numberOfCars = 256;
        Random random = new Random();
        List<Car> cars= new List<Car>();

        public ParkingLot()
        {
            return;

            for (int i = 0; i < numberOfCars; i++)
            {
                cars[i] = new Car(
                    (CarColor)random.Next(typeof(CarColor).GetEnumNames().Length),
                    (CarType)random.Next(typeof(CarType).GetEnumNames().Length));
            }
        }

        public override string ToString()
        {
            return $"Parking Lot:\nCapacity: {numberOfCars}"
                +$"\nNumber of parking cars: {cars.Count}";
        }
    }
}
