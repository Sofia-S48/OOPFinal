using System;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;
using VehicleManagementSystem.Vehicles;

namespace VehicleManagementSystem.IndependentClasses
{
    class VehicleComparer()
    {
        public void SortByPrice(Vehicle[] vehicles)
        {
            int n = vehicles.Length;

            for(int i = 0; i <n -1; i++)
            {
                for(int j = 0; j <n-i -1; j++)
                {
                    if (vehicles[j].Price > vehicles[j +1].Price)
                    {
                        Vehicle tempP = vehicles[j];
                        vehicles[j] = vehicles[j+1];
                        vehicles [j+1] = tempP;
                    }
                }
            }

        }

        public void SortBySpeed(Vehicle[] vehicles)
        {
            int n = vehicles.Length;

            for(int i = 0; i < n -1; i++)
            {
                for(int j = 0; j < n -i -1; j++)
                {
                    if(vehicles[j].Speed > vehicles[j + 1].Speed)
                    {
                        Vehicle tempS = vehicles[j];
                        vehicles[j] = vehicles[j+1];
                        vehicles[j+1] = tempS;
                    }
                }
            }

        }

        public void SortByType(Vehicle[] vehicles)
        {
            int n = vehicles.Length;

            for(int i = 0; i < n -1; i++)
            {
                for(int j = 0; j < n -i -1; j++)
                {
                    if (string.Compare(vehicles[j].VehicleType, vehicles[j+1].VehicleType) > 0)
                    {
                        Vehicle tempT = vehicles[j];
                        vehicles[j] = vehicles[j +1];
                        vehicles[j+1] = tempT;
                    }
                }
            }

        }
    }
}