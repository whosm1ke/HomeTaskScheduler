using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
namespace HomeTaskScheduler.Infrastructure;

public static class ConfigureInfrastructure
{
    public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
       
        return services;
    }
}