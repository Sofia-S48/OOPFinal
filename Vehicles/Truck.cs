namespace VehicleManagementSystem.Vehicles
{
    class Truck : Vehicle
    {
        public double LoadCapacity { get; set; }

        public Truck(string name, double price, double speed, string vehicleType, double loadCapacity) : base(name, price, speed, vehicleType)
        {
            LoadCapacity = loadCapacity;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Vehicle Type: {VehicleType}");
            Console.WriteLine($"Load Capacity: {loadCapacity}");
        }
        public override double CalculateTax()
        {
            return Price * 0.20;
        }
    }
}