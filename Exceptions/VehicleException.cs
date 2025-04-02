using System;
namespace VehicleManagementSystem.Exceptions
{
    public class VehicleException : Exception{
        public VehicleException(string message) : base(message)
        {
            
        }
    }
}