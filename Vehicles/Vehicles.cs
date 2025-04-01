
using System;

namespace VehicleManagementSystem.Vehicles
{

    public abstract class Vehicle
    {
        public string Name{ get; set; }
        public double Price { get; set; }
        public double Speed { get; set; }
        public string VehicleType{get; set;}

        public Vehicle(string name, double price, double speed, string vehicleType)
        {
            if(price < 0)
                throw new InvalidPriceException("Price can't be negative.");
            if (speed <= 0)
                throw new InvalidSpeedException("Speed cant be zero or less");
            
            Name = name;
            Price = price;
            Speed = speed;
            VehicleType = vehicleType;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Vehicle Type: {VehicleType}");
        }
        public abstract double CalculateTax();

    }
}
