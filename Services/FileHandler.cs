using System.IO;
using System.Collections.Generic;
using VehicleManagementSystem.Vehicles;

namespace VehicleManagementSystem.Services
{
    class FileHandler
    {
        private string path = "vehicles.txt";
        public void Save(Vehicle[] vehicles)
        {
            using (StreamWriter writer = new StreamWriter (path))
            {
                foreach(object vehicle in vehicles)
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


    }
}