namespace VehicleManagementSystem.Vehicles
{
    class RaceCar : Car
    {
        public bool TurboBoost { get; set; }

        public RaceCar(string name, double price, double speed, string vehicleType, string model, int horsePower, bool turboBoost) : base(name, price, speed, vehicleType, model, horsePower)
        {
            TurboBoost = turboBoost;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Vehicle Type: {VehicleType}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Horse Power: {HorsePower}");
            Console.WriteLine($"Turbo Boost: {TurboBoost}");
        }
    }
}