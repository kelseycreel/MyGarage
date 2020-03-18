using System;
using System.Collections.Generic;
using MyGarage.Aircrafts;
using MyGarage.Cars;
using MyGarage.Watercrafts;

namespace MyGarage
{
    class Program
    {
        public static void Main()
        {
            var airbus = new Airbus();
            var boeing = new Boeing();
            var dinghy = new Dinghy();
            var titanic = new Yacht();
            var sequoia = new Sequoia();
            var beetle = new Beetle();

            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()
            var flyings = new List<Aircraft> { airbus, boeing };
            foreach (var flying in flyings)
            {
                flying.Flying();
            }

            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()
            var drivings = new List<Car> { sequoia, beetle };
            foreach (var driving in drivings)
            {
                driving.Driving();
            }

            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
            var waterings = new List<Watercraft> { dinghy, titanic };
            foreach (var watering in waterings)
            {
                watering.Driving();
            }

        }
    }
}
