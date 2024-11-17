namespace HomeTaskScheduler.Application.Exceptions;

public abstract class BaseError : ApplicationException
{
    public DateTime ErrorTime { get; }
    public string ErrorLocation { get; }

    public BaseError() 
    {
        ErrorTime = DateTime.UtcNow;
    }

    public BaseError(string message) : base(message) 
    {
        ErrorTime = DateTime.UtcNow;
    }

    public BaseError(string message, Exception innerException) : base(message, innerException) 
    {
        ErrorTime = DateTime.UtcNow;
    }

    public BaseError(string message, string location) : base(message)
    {
        ErrorTime = DateTime.UtcNow;
        ErrorLocation = location;
    }

    public BaseError(string message, string location, Exception innerException) : base(message, innerException)
    {
        ErrorTime = DateTime.UtcNow;
        ErrorLocation = location;
    }
}