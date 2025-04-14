using System.IO;
using System.Collections.Generic;
using VehicleManagementSystem.Vehicles;

namespace VehicleManagementSystem.Services
{
    class FileHandler
    {
        private string path = "vehicleManagement.txt";
        public void Save(Vehicle[] vehicles)
        {
            using (StreamWriter write = new StreamWriter (path))
            {
                foreach(object vehicle in vehicles)
                {
                    writer.Write($"{vehicle.VehicleType},");
                    writer.Write($"{vehicle.Name},");
                    writer.Write($"{vehicle.Price},");
                    writer.Write($"{vehicle.Speed}.");
                    if(vehicle.GetType() == typeof(Airplane) )
                    {
                        writer.Write($"{vehicle.Altitude}");
                    }
                    else if (vehicle.GetType() == typeof(Boat))
                    {
                        writer.Write($"{vehicle.SeatingCapacity}");
                    }
                    else if (vehicle.GetType() == typeof(Car))
                    {
                        writer.Write($"{vehicle.model}, {vehicle.HorsePower}");
                    }
                    else if (vehicle.GetType() == typeof(CargoAirplane))
                    {
                        writer.Write($"{vehicle.CargoCapacity}");
                    }
                    else if (vehicle.GetType() == typeof(LuxuryYacht))
                    {
                        writer.Write($"{vehicle.Helipad}");
                    }
                    else if (vehicle.GetType() == typeof(RaceCar))
                    {
                        writer.Write($"{vehicle.TurboBoost}");
                    }
                    else if (vehicle.GetType() == typeof(Train))
                    {
                        writer.Write($"{vehicle.Units}");
                    }
                    else if (vehicle.GetType() == typeof(Truck))
                    {
                        writer.Write($"{vehicle.LoadCapacity}");
                    }
                    writer.WriteLine();
                }
            }
            Console.WriteLine("Vehicles saved.");
        }
    }
}