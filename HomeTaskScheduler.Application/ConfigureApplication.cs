using HomeTaskScheduler.Application.Configs;
using HomeTaskScheduler.Application.Contracts.Utils;
using HomeTaskScheduler.Application.Utils;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Xabe.FFmpeg;

namespace HomeTaskScheduler.Application;

public static class ConfigureApplication
{
    public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.Configure<AttachmentSettings>(_ => configuration.GetSection("AttachmentSettings"));
        string ffmpegExec = configuration["FFmpegConfig:ExecutableLocation"];
        FFmpeg.SetExecutablesPath(ffmpegExec);
        services.AddTransient<IThumbnailGenerator, ImageThumbnailGenerator>();
        services.AddTransient<IThumbnailGenerator, VideoThumbnailGenerator>();
        services.AddSingleton<ThumbnailGeneratorFactory>();
        return services;
    }
}