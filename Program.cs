using System;
using VehicleManagementSystem.Vehicles;
using VehicleManagementSystem.Services;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main()
    {
        VehcileManager manager = new VehcileManager();

        Car myCar = new Car("Chevrolet", 350, 50000, "Cruze", 250);
        Console.AddVehicle(myCar);

        
    }
}