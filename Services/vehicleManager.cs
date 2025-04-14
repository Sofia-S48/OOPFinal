using System.Collections.Generic;
using VehicleManagementSystem.Vehicles;

namespace VehicleManagementSystem.Services
{
    class VehicleManager
    {
        private Vehicle[] vehicles;
        private int vehicleCount;

        public VehicleManager()
        {
            vehicles = new Vehicle[100];
            vehicleCount = 0;
        }
        public void RemoveVehicle(int index)
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
        public void AddVehicle(Vehicle vehicle)
        {
            if (vehicleCount >= vehicles.Length)
            {
                Console.WriteLine("Vehicle array is full. Can't add more vehicles.");
                return;
            }
            vehicles[vehicleCount] = vehicle;
            vehicleCount++;
            
        }
        public void DisplayVehicles()
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
        public Vehicle[] GetVehicles()
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