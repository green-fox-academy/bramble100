﻿using System;
using System.Collections.Generic;

namespace GardenApp
{
    internal class Garden : List<Plant>
    {

        public Garden(List<Plant> plants) : base(plants) => plants.ForEach(item => Add(item));

        public Garden()
        {
        }

        internal void AddFlowers(List<Flower> list) => list.ForEach(item => Add(item));

        internal void AddTrees(List<Tree> list) => list.ForEach(item => Add(item));

        internal void Water(int water)
        {
            Console.WriteLine($"Watering with {water}");

            int numberOfPlantsNeedWatering = 0;
            ForEach(item => numberOfPlantsNeedWatering += item.NeedsWatering() ? 1 : 0);

            int waterForOnePlant = water / numberOfPlantsNeedWatering;

            ForEach(item => item.Water(waterForOnePlant));

            Console.WriteLine();
        }

        internal void DisplayStatusReport()
        {
            Console.WriteLine("Garden Status Report");
            Console.WriteLine("--------------------");
            ForEach(item => Console.WriteLine(item.DisplayStatusReport()));
            Console.WriteLine();
        }
    }
}