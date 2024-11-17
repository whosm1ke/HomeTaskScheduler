namespace HomeTaskScheduler.Application.Exceptions;

public class NoAccessException : BaseError
{
    public NoAccessException() { }

    public NoAccessException(string message) : base(message) { }

    public NoAccessException(string message, Exception innerException) : base(message, innerException) { }

    public NoAccessException(string message, string location) : base(message, location) { }

    public NoAccessException(string message, string location, Exception innerException) : base(message, location, innerException) { }
}