using System;
using System.Runtime.CompilerServices;

using VehicleManagementSystem.Vehicles;
using VehicleManagementSystem.Services;
using VehicleManagementSystem.Exceptions;
using VehicleManagementSystem.IndependentClasses;
using VehicleManagementSystem.Constants;
using Microsoft.Win32.SafeHandles;

class Program
{
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
                    
                break;
                case 2:
                    
                break;
                case 3:
                    Console.WriteLine("Sorting by price, speed, and type");
                break;
                case 4:
                    Console.WriteLine("Statistics: ");
                break;

            }
        
        }
    }
}