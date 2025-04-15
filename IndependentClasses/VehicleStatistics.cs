using System;
using System.Linq;
using VehicleManagementSystem.Vehicles;
using VehicleManagementSystem.Constants;
using VehicleManagementSystem.IndependentClasses;

namespace VehicleManagementSystem.IndependentClasses
{
    class VehicleStatistics
    {
        public static double getAveragePrice(Vehicle[] vehicles)
        {
            if (vehicles.Length == 0) return 0;
            return vehicles.Average(v => v.Price);
        }
        public static Vehicle SortFastest(Vehicle[]vehicles)
        {
            if (vehicles.Length == 0) return null;
            VehicleComparer.SortBySpeed(vehicles);
            return vehicles[^1];
        }

        public static int CountByType(Vehicle[] vehicles, VehicleConstants.VehicleTypes type)
        {
            return vehicles.Count(v => v.VehicleType == type.ToString());
        }
    }
}
