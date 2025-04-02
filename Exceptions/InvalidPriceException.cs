namespace VehicleManagementSystem.Exceptions
{
    public class InvalidPriceException : VehicleException
    {
        public InvalidPriceException() : base("Price cant be negative")
        {
            
        }
    }
}