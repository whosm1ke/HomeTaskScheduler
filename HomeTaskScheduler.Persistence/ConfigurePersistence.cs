using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace HomeTaskScheduler.Persistence;

public static class ConfigurePersistence
{
    public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
       
        return services;
    }
}