namespace HomeTaskScheduler.Application.Exceptions;

public class BadRequestException : BaseError
{
    public BadRequestException() { }

    public BadRequestException(string message) : base(message) { }

    public BadRequestException(string message, Exception innerException) : base(message, innerException) { }

    public BadRequestException(string message, string location) : base(message, location) { }

    public BadRequestException(string message, string location, Exception innerException) : base(message, location, innerException) { }
}