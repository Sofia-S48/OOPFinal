namespace VehicleManagementSystem.Exceptions
{
    class InvalidCargoCapacityException : Exception
    {
        public InvalidCargoCapacityException() : base("Cargo capacity is invalid") { }

        public InvalidCargoCapacityException(string message) : base(message) { }
    }
}