using HomeTaskScheduler.Application.Contracts.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace HomeTaskScheduler.Application.Utils;

public class ThumbnailGeneratorFactory
{
    private readonly IServiceProvider serviceProvider;

    public ThumbnailGeneratorFactory(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
    }

    public IThumbnailGenerator GetThumbnailGenerator(ThumbnailType type)
    {
        return type switch
        {
            ThumbnailType.Image => serviceProvider.GetRequiredService<ImageThumbnailGenerator>(),
            ThumbnailType.Video => serviceProvider.GetRequiredService<VideoThumbnailGenerator>(),
            _ => throw new ArgumentException("Invalid thumbnail type.")
        };
    }
}