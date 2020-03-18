using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Cars
{
    class Sequoia : Car
    {
        public bool TreeOrNoTree => true;

        public void OhWiseOne()
        {
            if (TreeOrNoTree)
                Console.WriteLine("A sequoia is a tree that will never leaf you.");
        }
    }
}
