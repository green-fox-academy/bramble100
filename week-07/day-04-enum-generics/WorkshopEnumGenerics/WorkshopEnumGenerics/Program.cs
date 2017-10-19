using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopEnumGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingLot parkingLot = new ParkingLot();
            Console.WriteLine(parkingLot);
            Console.WriteLine();
            Console.WriteLine(parkingLot.ColorsOfParkingCars);
            Console.WriteLine();
            Console.WriteLine(parkingLot.TypesOfParkingCars);
            Console.WriteLine();
            Console.WriteLine(parkingLot.ColorsAndTypesOfParkingCars);
            Console.WriteLine();
            Console.WriteLine(parkingLot.MostFrequentCar);
            Console.ReadKey();
        }
    }
}
