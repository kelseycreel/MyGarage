using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Cars
{
    class Beetle : Car
    {
        public bool BugOrNoBug => true;

        public void OhWiseOne()
        {
            if (BugOrNoBug)
                Console.WriteLine("A beetle can be squashed.");
        }
    }
}
