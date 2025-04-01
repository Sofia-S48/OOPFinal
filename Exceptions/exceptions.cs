
class InvalidPriceException : Exception
{
    public InvalidPriceException() : base("Price is invalid") { }

    public InvalidPriceException(string message) : base(message) { }
}


class InvalidSpeedException : Exception
{
    public InvalidSpeedException() : base("Speed is invalid") { }

    public InvalidSpeedException(string message) : base(message) { }
}

class InvalidCargoCapacityException : Exception
{
    public InvalidCargoCapacityException() : base("Cargo capacity is invalid") { }

    public InvalidCargoCapacityException(string message) : base(message) { }
}

