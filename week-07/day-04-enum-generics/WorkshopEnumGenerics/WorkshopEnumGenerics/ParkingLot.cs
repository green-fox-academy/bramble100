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
        List<Car> cars = new List<Car>();

        public ParkingLot(int numberOfCars = 256)
        {
            this.numberOfCars = numberOfCars;
            for (int i = 0; i < numberOfCars; i++)
            {
                cars.Add(new Car(
                    (CarColor)random.Next(typeof(CarColor).GetEnumNames().Length),
                    (CarType)random.Next(typeof(CarType).GetEnumNames().Length)));
            }
        }

        public string ColorsOfParkingCars
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();

                (from car in cars
                 group car by car.Color
                 into colors
                 select colors)
                    .ToList()
                    .ForEach(x =>
                   stringBuilder.AppendLine($"{x.Key}: {x.Count()}"));

                return stringBuilder.ToString();
            }
        }

        public string ColorsAndTypesOfParkingCars
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();

                var query = cars.GroupBy(car => $"{car.Color} {car.Type}", car => car).OrderBy(c => c.Count());
                query.ToList().ForEach(group => stringBuilder.AppendLine($"{group.Key} {group.Count()}"));
                return stringBuilder.ToString();
            }
        }

        public override string ToString()
        {
            return $"Parking Lot:\nCapacity: {numberOfCars}"
                + $"\nNumber of parking cars: {cars.Count}";
        }
    }
}
