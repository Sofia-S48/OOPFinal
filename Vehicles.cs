
using System;



abstract class Vehicle
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
    public abstract double CalculateTax(){}

}

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
}

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

class CargoAirplane : Airplane
{
    public double cargoCapacity;
    public double CargoCapacity
    {
        get{return cargoCapacity;}
        set
        {
            if (value < & value > 100000)
            {
                throw new InvalidCargoCapacityException("Cargo must be lighter than 100,000 Kg, and cannot be negative");
                cargoCapacity = value;
            }
        }
    }
    public CargoAirplane(string name, double price, double speed, string vehicleType, double altitude, int cargoCapacity) : base(name, price, speed, vehicleType)  
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

class Truck : Vehicle
{
    public double loadCapacity { get; set; }

    public Truck(string name, double price, double speed, string vehicleType, double loadCapacity) : base(name, price, speed, vehicleType)
    {
        this.loadCapacity = loadCapacity;
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




