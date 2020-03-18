using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Aircrafts
{
    class Boeing : Aircraft
    {
        public bool HasDoors { get; set; }
        public void CoolOrNotCool()
        {
            if (!HasDoors)
                Console.WriteLine("This is a cool airplane, with no doors");
        }

    }
}
