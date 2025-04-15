using VehicleManagementSystem.Exceptions;
namespace VehicleManagementSystem.Vehicles
{
    class CargoAirplane : Airplane
    {
        private double cargoCapacity;
        public double CargoCapacity
        {
            get{return cargoCapacity;}
            set
            {
                if (value < 0 && value > 100000)
                {
                    throw new InvalidCargoCapacityException("Cargo must be lighter than 100,000 Kg, and cannot be negative");
                }
                cargoCapacity = value;
            }
        }
        public CargoAirplane(string name, double price, double speed, string vehicleType, double altitude, double cargoCapacity) : base(name, price, speed, vehicleType, altitude)  
        {
            CargoCapacity = cargoCapacity;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Vehicle Type: {VehicleType}");
            Console.WriteLine($"Altitude: {Altitude}");
            Console.WriteLine($"Cargo Capacity: {CargoCapacity}");
        }
    }
}