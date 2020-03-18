using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Aircrafts
{
    abstract class Aircraft : Vehicle
    {
        //refueling, flying, and landing
        public override void Refueling()
        {
            Console.WriteLine("Refueling the helicopter!");
        }

        public void Flying()
        {
            Console.WriteLine("Flying the helicopter!");
        }

        public void Landing()
        {
            Console.WriteLine("Landing the helicopter!");
        }
    }
}
