using HomeTaskScheduler.API.Constants;
using HomeTaskScheduler.Application.Exceptions;
using Serilog;

namespace HomeTaskScheduler.API.Middleware;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception e)
        {
            await HandleExceptionAsync(context, e);
        }
    }

    private async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";
        switch (exception)
        {
            case BadRequestException bad:
                Log.Error("{ErrorName} [{When}]: {Location}",
                    nameof(BadRequestException), bad.ErrorTime,
                    bad.ErrorLocation);
                WriteResult(context, StatusCodes.Status400BadRequest, FailureCode.BadRequest, bad.Message);
                break;
            case NotFoundException notFound:
                Log.Error("{ErrorName} [{When}]: {Location}",
                    nameof(NotFoundException), notFound.ErrorTime,
                    notFound.ErrorLocation);
                WriteResult(context, StatusCodes.Status404NotFound, FailureCode.NotFound, notFound.Message);
                break;
            case NoAccessException noAccess:
                Log.Error("{ErrorName} [{When}]: {Location}",
                    nameof(NoAccessException), noAccess.ErrorTime,
                    noAccess.ErrorLocation);
                WriteResult(context, StatusCodes.Status404NotFound, FailureCode.NoAccess, noAccess.Message);
                break;
            case ValidationException validationException:

                Log.Error("{ValidationException} [{When}]: {Location}\n {@Details}",
                    nameof(NoAccessException), validationException.ErrorTime,
                    validationException.ErrorLocation, validationException.ToString());
                WriteResult(context, StatusCodes.Status404NotFound, FailureCode.ValidationFailed,
                    validationException.ToString());
                break;
            default:
                Log.Error("{ErrorName} [{When}]",
                    nameof(Exception), DateTime.UtcNow);
                WriteResult(context, StatusCodes.Status404NotFound, FailureCode.InternalError,
                    "Probably internal server Error");
                break;
        }
    }

    private static void WriteResult(HttpContext context, int httpCode, FailureCode failureCode, string message)
    {
        context.Response.StatusCode = httpCode;
        context.Response.Headers.Append(ExceptionsConstants.ReasonCodeOutHeader, failureCode.ToString());
        context.Response.Headers.Append(ExceptionsConstants.ReasonMessageOutHeader, message);
        context.Response.WriteAsync(message);
    }
}

public static class ExceptionMiddlewareExtensions
{
    public static IApplicationBuilder UseExceptionMiddleware(this IApplicationBuilder app)
    {
        return app.UseMiddleware<ExceptionMiddleware>();
    }
}