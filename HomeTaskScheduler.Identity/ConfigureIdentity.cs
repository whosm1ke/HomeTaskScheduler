using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClassLibrary1HomeTaskScheduler.Identity;

public static class ConfigureIdentity
{
    
    public static IServiceCollection ConfigureIdentityServices(this IServiceCollection services,
        IConfiguration configuration)
    {
       

        return services;
    }
}