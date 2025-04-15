using System.Collections.Generic;
using VehicleManagementSystem.Vehicles;

namespace VehicleManagementSystem.Services
{
    static class VehicleManager
    {
        private static Vehicle?[] vehicles = new Vehicle [100];
        private static int vehicleCount = 0;

       
        public static void RemoveVehicle(int index)
        {
            if(index < 0 && index >= vehicleCount)
            {
                Console.WriteLine("Invalid index. Can't remove vehicle.");
                return;
            }

            for (int i = index; i < vehicleCount-1 ; i++)
            {
                vehicles[i] = vehicles [i +1];
            }

            vehicles[ vehicleCount - 1] = null;
            vehicleCount --;
        }
        public static void AddVehicle(Vehicle vehicle)
        {
            if (vehicleCount >= vehicles.Length)
            {
                Console.WriteLine("Vehicle array is full. Can't add more vehicles.");
                return;
            }
            vehicles[vehicleCount] = vehicle;
            vehicleCount++;
            
        }
        public static void DisplayVehicles()
        {
            if (vehicleCount == 0)
            {
                Console.WriteLine("There are no vehicles to display.");
                return;
            }

            for (int i = 0; i < vehicleCount; i++)
            {
                Console.WriteLine($"\nVehicle #{i + 1}");
                vehicles[i].DisplayInfo();
            }

        }
        public static Vehicle[] GetVehicles()
        {
            Vehicle[] currentVehicles = new Vehicle[vehicleCount];
    
            for (int i = 0; i < vehicleCount; i++)
            {
                currentVehicles[i] = vehicles[i];
            }
            return currentVehicles;
        }
    }

}