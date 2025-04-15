using System.IO;
using System.Collections.Generic;
using VehicleManagementSystem.Vehicles;
using System.Diagnostics;

namespace VehicleManagementSystem.Services
{
    class FileHandler
    {
        private string path = "vehicles.txt";
        public void Save(Vehicle[] vehicles)
        {
            using (StreamWriter writer = new StreamWriter (path))
            {
                foreach(Vehicle vehicle in vehicles)
                {
                    Vehicle baseVehicle = vehicle;

                    writer.Write($"{baseVehicle.VehicleType},");
                    writer.Write($"{baseVehicle.Name},");
                    writer.Write($"{baseVehicle.Price},");
                    writer.Write($"{baseVehicle.Speed}.");
                    if(vehicle.GetType() == typeof(Airplane) )
                    {
                        Airplane airplane = (Airplane)vehicle;
                        writer.Write($"{airplane.Altitude}");
                    }
                    else if (vehicle.GetType() == typeof(Boat))
                    {
                        Boat boat = (Boat)vehicle;
                        writer.Write($"{boat.SeatingCapacity}");
                    }
                    else if (vehicle.GetType() == typeof(Car))
                    {
                        Car car = (Car)vehicle;
                        writer.Write($"{car.Model}, {car.HorsePower}");
                    }
                    else if (vehicle.GetType() == typeof(CargoAirplane))
                    {
                        CargoAirplane cargo = (CargoAirplane)vehicle;
                        writer.Write($"{cargo.CargoCapacity}");
                    }
                    else if (vehicle.GetType() == typeof(LuxuryYacht))
                    {
                        LuxuryYacht yacht = (LuxuryYacht)vehicle;
                        writer.Write($"{yacht.Helipad}");
                    }
                    else if (vehicle.GetType() == typeof(RaceCar))
                    {
                        RaceCar race = (RaceCar)vehicle;
                        writer.Write($"{race.TurboBoost}");
                    }
                    else if (vehicle.GetType() == typeof(Train))
                    {
                        Train train = (Train)vehicle;
                        writer.Write($"{train.Units}");
                    }
                    else if (vehicle.GetType() == typeof(Truck))
                    {
                        Truck truck = (Truck)vehicle;
                        writer.Write($"{truck.LoadCapacity}");
                    }
                    writer.WriteLine();
                }
            }
            Console.WriteLine("Vehicles saved.");
        }

        public Vehicle[] LoadFromFile()
        {
            if(!File.Exists(path))
            {
                Console.WriteLine("No saved Vehicles");
                return new Vehicle[0];
            }

            List<Vehicle> vehicleList = new List<Vehicle>();

            foreach(string line in File.ReadAllLines(path))
            {
                string[] part = line.Split(',');

                string type = part[0];
                string name = part[1];
                double price = Convert.ToDouble(part[2]);
                int speed = Convert.ToInt32(part[3]);

                switch (type)
                {
                    case "Airplane":
                    {
                        double altitude = Convert.ToDouble(part[4]);
                        vehicleList.Add(new Airplane(name, price, speed, type, altitude));
                        break;
                    }

                    case "Boat":
                    {
                        int seating = Convert.ToInt32(part[4]);
                        vehicleList.Add(new Boat(name, price, speed, type, seating));
                    break;
                    }

                    case "Car":
                    {
                        string model = part[4];
                        int horsepower = Convert.ToInt32(part[5]);
                        vehicleList.Add(new Car (name, price, speed, type, model, horsepower));
                    break;
                    }

                    case "CargoAirplane":
                    {
                        double altitudeCA = Convert.ToDouble(part[4]);
                        int cargo = Convert.ToInt32(part[5]);
                        vehicleList.Add(new CargoAirplane(name, price, speed, type, altitudeCA, cargo));
                    break;
                    }

                    case "LuxuryYacht":
                    {
                        int seatingCapacity = Convert.ToInt32(part[4]);
                        bool helipad = Convert.ToBoolean(part[5]);
                        vehicleList.Add(new LuxuryYacht(name, price, speed, type, seatingCapacity, helipad));
                    break;
                    }

                    case "RaceCar":
                    {
                        string model = part[4];
                        int horsePower = Convert.ToInt32(part[5]);
                        bool turbo = Convert.ToBoolean(part[6]);
                        vehicleList.Add(new RaceCar(name, price, speed, type, model, horsePower, turbo));
                    break;
                    }

                    case "Train":
                    {
                        int units = Convert.ToInt32(part[4]);
                        vehicleList.Add(new Train(name, price, speed, type, units));
                    break;
                    }

                    case "Truck":
                    {
                        double load = Convert.ToDouble(part[4]);
                        vehicleList.Add(new Truck(name, price, speed, type, load));
                    break;
                    }

                    default:
                    {
                        Console.WriteLine("Vehicle type not found:" + type);
                    break;
                    }

                }
            }
            return vehicleList.ToArray();
        }


    }
}