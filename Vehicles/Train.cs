namespace VehicleManagementSystem.Vehicles
{
    class Train : Vehicle
    {
        public int Units { get; set; }
        public Train(string name, double price, double speed, string vehicleType, int units) : base(name, price, speed, vehicleType)
        {
            Units = units;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Vehicle Type: {VehicleType}");
            Console.WriteLine($"Units: {Units}");
        }

        public override double CalculateTax()
        {
            return Price * 0.05;
        }
    }
}