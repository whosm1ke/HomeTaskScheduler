namespace HomeTaskScheduler.Application.Exceptions;

public static class Guard
{
    public static void ThrowBadRequestIfNull(this object obj, string msg, string? location)
    {
        if (obj is null)
        {
            throw new BadRequestException(msg, location);
        }
    }
}