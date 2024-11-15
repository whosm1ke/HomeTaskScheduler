using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace HomeTaskScheduler.Persistence;

public static class ConfigurePersistence
{
    public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("LocalDbConnectionString"))
                .LogTo(Console.WriteLine, LogLevel.Information);
        });
        return services;
    }
}