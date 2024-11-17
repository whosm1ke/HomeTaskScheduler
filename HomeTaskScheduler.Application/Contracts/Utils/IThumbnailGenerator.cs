namespace HomeTaskScheduler.Application.Contracts.Utils;

public interface IThumbnailGenerator
{
    string BasePath { get; set; }
    Task<string> GenerateThumbnailAsync(Stream sourceStream, string fileName, int width, int height);
}