namespace VehicleManagementSystem.Exceptions
{
    class InvalidSpeedException : Exception
    {
        public InvalidSpeedException() : base("Speed is invalid") { }

        public InvalidSpeedException(string message) : base(message) { }
    }
}