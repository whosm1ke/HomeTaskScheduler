namespace HomeTaskScheduler.Application.Exceptions;

using Newtonsoft.Json;

public class ValidationException : BaseError
{
    
    public ValidationException(IDictionary<string, string[]> errors)
    {
        Errors = errors;
        ErrorTime = DateTime.UtcNow;
    }

    public ValidationException(string property, string error) : base(error,property)
    {
        Errors = new Dictionary<string, string[]> { { property, [error] } };
        ErrorTime = DateTime.UtcNow;
    }

    public DateTime ErrorTime { get; }
    public IDictionary<string, string[]> Errors { get; }

    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }
}