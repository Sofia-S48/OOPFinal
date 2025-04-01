namespace VehicleManagementSystem.Vehicles
{
    class Car : Vehicle
    {
        public string Model { get; set; }
        public int HorsePower { get; set; }

        public Car(string name, double price, double speed, string vehicleType, string model, int horsePower) : base(name, price, speed, vehicleType)
        {
            Model = model;
            HorsePower = horsePower;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Vehicle Type: {VehicleType}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Horse Power: {HorsePower}");
        }
        public override double CalculateTax()
        {
            return Price * 0.10;
        }

    }
}