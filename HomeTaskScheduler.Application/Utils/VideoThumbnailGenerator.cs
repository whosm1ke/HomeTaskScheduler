using HomeTaskScheduler.Application.Contracts.Utils;
using Xabe.FFmpeg;

namespace HomeTaskScheduler.Application.Utils;

public class VideoThumbnailGenerator : IThumbnailGenerator
{
    public string BasePath { get; set; }

    public async Task<string> GenerateThumbnailAsync(Stream sourceStream, string fileName, int width, int height)
    {
        string tempVideoPath = Path.GetTempFileName();
        using (var fileStream = new FileStream(tempVideoPath, FileMode.Create, FileAccess.Write))
        {
            await sourceStream.CopyToAsync(fileStream);
        }

        string outputFilePath = Path.Combine(BasePath, fileName);

        await FFmpeg.Conversions.New()
            .AddParameter($"-i {tempVideoPath} -vf \"thumbnail,scale={width}:{height}\" -frames:v 1 {outputFilePath}")
            .Start();

        File.Delete(tempVideoPath);
        return outputFilePath;
    }
}