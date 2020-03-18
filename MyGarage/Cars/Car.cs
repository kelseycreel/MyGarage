using System;
using System.Collections.Generic;
using System.Text;
using MyGarage;

namespace MyGarage.Cars
{
    abstract class Car : Vehicle
    {
        //Include methods for refueling, driving, and braking
        public override void Refueling()
        {
            Console.WriteLine($"Refueled the car!");
        }

        public void Driving()
        {
            Console.WriteLine($"Driving the car!");
        }

        public void Braking()
        {
            Console.WriteLine($"Stopping the car!");
        }
    }
}
