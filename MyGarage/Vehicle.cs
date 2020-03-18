using System;
using System.Collections.Generic;
using System.Text;

namespace MyGarage
{
    abstract class Vehicle
    {
        //fuel/battery capacity, color, and passenger occupancy
        public string FuelCapacity { get; set; }
        public VehicleColor VehicleColor { get; set; }
        public int PassengerOccupancy { get; set; }

        public abstract void Refueling();
    }

    enum VehicleColor
    {
        Black,
        White,
        Silver,
        Multi,
        Blue,
        Red,
        Green
    }
}
