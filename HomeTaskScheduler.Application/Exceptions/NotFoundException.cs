namespace HomeTaskScheduler.Application.Exceptions;

public class NotFoundException : BaseError
{
    public NotFoundException() { }

    public NotFoundException(string message) : base(message) { }

    public NotFoundException(string message, Exception innerException) : base(message, innerException) { }

    public NotFoundException(string message, string location) : base(message, location) { }

    public NotFoundException(string message, string location, Exception innerException) : base(message, location, innerException) { }
}