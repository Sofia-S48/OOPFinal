using System;
using System.Runtime.CompilerServices;

using VehicleManagementSystem.Vehicles;
using VehicleManagementSystem.Services;
using VehicleManagementSystem.Exceptions;
using VehicleManagementSystem.IndependentClasses;
using VehicleManagementSystem.Constants;
using Microsoft.Win32.SafeHandles;
using System.Numerics;
using Microsoft.VisualBasic;

namespace VehicleManagementSystem
{
class Program
{
    static void showStats(VehicleManager manager)
    {
        Vehicle[] vehicles = manager.GetVehicles();

        Console.WriteLine($"Average Price: {VehicleStatistics.getAveragePrice(vehicles)}");
        var fastest = VehicleStatistics.SortFastest(vehicles);
        Console.WriteLine($"Fastest Vehicle: {fastest?.Name}, Speed: {fastest?.Speed} km/h");

        foreach(var type in Enum.GetValues(typeof(VehicleConstants.VehicleTypes)))
        {
            int count = VehicleStatistics.CountByType(vehicles, (VehicleConstants.VehicleTypes)type);
            Console.WriteLine($"{type}: {count}");
        }
    }

    static void AddVehicles(VehicleManager manager)
    {
        Console.WriteLine("Vehicle types: Airplane, Boat, Car, CargoAirplane, LuxuryYacht, RaceCar, Train, Truck.");
        Console.WriteLine("Enter Vehicle type: ");
        string type = Console.ReadLine();

        Console.WriteLine("Enter Vehicle Name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Vehicle Price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Vehicle Speed: ");
        double speed = Convert.ToDouble(Console.ReadLine());

        // Type specific questions:

        Vehicle newVehicle = null;

        switch (type)
        {
            case "Airplane":
                Console.WriteLine("Altitude: ");
                double alt = Convert.ToDouble(Console.ReadLine());
                newVehicle = new Airplane(name, price, speed, type, alt);
            break;
            case "Boat":
                Console.WriteLine("Boat's seating capacity: ");
                int seating = Convert.ToInt32(Console.ReadLine());
                newVehicle = new Boat(name, price, speed, type, seating);
            break;
            case "car":
                Console.WriteLine("Enter car Model: ");
                string model = Console.ReadLine();
                Console.WriteLine("Enter car Horsepower: ");
                int horsepower = Convert.ToInt32(Console.ReadLine());
                newVehicle = new Car(name, price, speed, type, model, horsepower);
            break;
            case "CargoAirplane":
                Console.WriteLine("Altitude: ");
                double altC = Convert.ToDouble(Console.ReadLine());
                try{
                Console.WriteLine("Plane's cargo capacity: ");
                double cargo = Convert.ToDouble(Console.ReadLine());
                newVehicle = new CargoAirplane(name, price, speed, type, altC, cargo);
                }
                catch(VehicleException ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
                catch(InvalidCargoCapacityException ex) 
                {
                    Console.WriteLine($"{ex.Message}");
                }
            break;
            case "LuxuryYacht":
                Console.WriteLine("Luxury Yacht seating capacity: ");
                int yachtSeating = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Helipad('yes' or 'no'): ");
                string ans = Console.ReadLine().ToLower();
                bool helipad = ans == "yes";
                newVehicle = new LuxuryYacht(name, price, speed, type, yachtSeating, helipad);
            break;
            case "RaceCar":
                Console.WriteLine("Enter car Model: ");
                string modelR = Console.ReadLine();

                Console.WriteLine("Enter car Horsepower: ");
                int horsepowerR = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Turbo Boost ('yes' or 'no'): ");
                string ansR = Console.ReadLine().ToLower();
                bool turbo = ansR == "yes";
                newVehicle = new RaceCar(name, price, speed, type, modelR, horsepowerR, turbo);
            break;
            case "Train":
                Console.WriteLine("Units: ");
                int units = Convert.ToInt32(Console.ReadLine());
                newVehicle = new Train(name, price, speed, type, units);
            break;
            case "Truck":
                Console.WriteLine("Truck load capacity: ");
                double loadC = Convert.ToDouble(Console.ReadLine());
                newVehicle = new Truck(name, price, speed, type, loadC);
            break;
        }

    }

    static void SortMenu(VehicleManager manager)
    {
        Console.WriteLine("\n===== Sort Options =====");
        Console.WriteLine("1. By Price");
        Console.WriteLine("2. By Speed");
        Console.WriteLine("3. By Type");
        string answ = Console.ReadLine();

        Vehicle[] vehicles = manager.GetVehicles();

        switch(answ)
        {
            case "1":
                VehicleComparer.SortByPrice(vehicles);
                Console.WriteLine("Sorted by price");
            break;
            case "2":
                VehicleComparer.SortBySpeed(vehicles);
                Console.WriteLine("Sorted by speed");
            break;
            case "3":
                VehicleComparer.SortByType(vehicles);
                Console.WriteLine("Sorted by type");
            break;
            default:
                Console.WriteLine("Invalid option");
            break;
        }

    }

    static void Main(string[] args)
    {
        VehicleManager vehicleManager = new();
        FileHandler fileHandler = new FileHandler();
        
        while (true)
        {

        
            Console.WriteLine("\n=====Vehicle Manager=====");
            Console.WriteLine("1.Add Vehicle");
            Console.WriteLine("2.Display all Vehicles");
            Console.WriteLine("3.Sort Vehicles");
            Console.WriteLine("4.Get statistics");
            Console.WriteLine("5.Save vehicles to file");
            Console.WriteLine("6.Load vehicles from file");
            Console.WriteLine("7.Exit");
            Console.WriteLine("Please enter your choice: ");

            if(!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please try again.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddVehicles(vehicleManager);
                break;
                case 2:
                    vehicleManager.DisplayVehicles();
                break;
                case 3:
                    SortMenu(vehicleManager);
                break;
                case 4:
                    showStats(vehicleManager);
                break;
                case 5:
                    fileHandler.Save(vehicleManager.GetVehicles());
                    Console.WriteLine("Vehicles saved");
                break;
                case 6:
                    Vehicle[] loadedVehicles = fileHandler.LoadFromFile();
                    foreach(var v in loadedVehicles)
                    {
                        vehicleManager.AddVehicle(v);
                    }
                    Console.WriteLine("Vehicles loaded to file.");
                break;

                case 7:
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid. Try again");
                break;

            }
        
        }
    }
}
}