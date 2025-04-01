namespace VehicleManagementSystem.Vehicles
{
    class Boat: Vehicle
    {
        public int SeatingCapacity { get; set; }

        public Boat(string name, double price, double speed, string vehicleType, int seatingCapacity) : base(name, price, speed, vehicleType)
        {
            SeatingCapacity = seatingCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Vehicle Type: {VehicleType}");
            Console.WriteLine($"Seating Capacity: {SeatingCapacity}");
        }
        public override double CalculateTax()
        {
            return Price *0.05;
        }
    }
}