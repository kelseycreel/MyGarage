using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Watercrafts
{
    class Yacht : Watercraft
    {
        public bool IsTitanic { get; set; }
        public void Sinking()
        {
            if (IsTitanic)
                Console.WriteLine("The ship is sinking, swim.");
            else
                Console.WriteLine("The ship isn't sinking yet.");
        }
    }
}
