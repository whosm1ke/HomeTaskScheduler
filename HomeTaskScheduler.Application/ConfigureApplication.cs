using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
namespace HomeTaskScheduler.Application;

public static class ConfigureApplication
{
    public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        return services;
    }
}