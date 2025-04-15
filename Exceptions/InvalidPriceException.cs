namespace VehicleManagementSystem.Exceptions
{
    class InvalidPriceException : Exception
    {
        public InvalidPriceException() : base("Price is invalid") { }

        public InvalidPriceException(string message) : base(message) { }
    }
}