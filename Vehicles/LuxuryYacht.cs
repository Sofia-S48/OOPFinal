namespace VehicleManagementSystem.Vehicles
{
    class LuxuryYacht : Boat
    {
        public bool Helipad { get; set; }

        public LuxuryYacht(string name, double price, double speed, string vehicleType, int seatingCapacity, bool helipad) : base(name, price, speed, vehicleType, seatingCapacity)
        {
            Helipad = helipad;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Vehicle Type: {VehicleType}");
            Console.WriteLine($"Seating Capacity: {SeatingCapacity}");
            Console.WriteLine($"Helipad: {Helipad}");
        }
    }
}