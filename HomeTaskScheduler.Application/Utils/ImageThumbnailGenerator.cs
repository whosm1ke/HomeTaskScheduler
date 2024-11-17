using HomeTaskScheduler.Application.Contracts.Utils;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Processing;

namespace HomeTaskScheduler.Application.Utils;

public class ImageThumbnailGenerator : IThumbnailGenerator
{
    public string BasePath { get; set; }

    public async Task<string> GenerateThumbnailAsync(Stream sourceStream, string fileName, int width, int height)
    {
        using (var image = Image.Load(sourceStream))
        {
            image.Mutate(x => x.Resize(width, height));
            string filePath = Path.Combine(BasePath, fileName);
            await image.SaveAsync(filePath, new PngEncoder());
            return filePath;
        }
    }
}