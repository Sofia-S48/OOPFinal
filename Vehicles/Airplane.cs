namespace VehicleManagementSystem.Vehicles
{
    class Airplane : Vehicle
    {
        public double Altitude { get; set; }

        public Airplane(string name, double price, double speed, string vehicleType, double altitude) : base(name, price, speed, vehicleType)
        {
            Altitude = altitude;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Vehicle Type: {VehicleType}");
            Console.WriteLine($"Altitude: {Altitude}");
        }
        public override double CalculateTax()
        {
        return Price *0.15;
        }
    }
}