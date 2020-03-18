using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Watercrafts
{
    class Watercraft : Vehicle
    {
        //refueling, driving
        public override void Refueling()
        {
            Console.WriteLine("Refueling the boat!");
        }

        public void Driving()
        {
            Console.WriteLine("Driving the boat!");
        }

    }
}
