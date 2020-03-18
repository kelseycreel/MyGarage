using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage.Watercrafts
{
    class Dinghy : Watercraft
    {
        public bool HasHole { get; set; }
        public void Sinking()
        {
            if (HasHole)
                Console.WriteLine("The dinghy is sinking, but it's no great loss anyway");
            else
                Console.WriteLine("The dinghy isn't sinking yet, but it wil be soon");
        }
    }
}
