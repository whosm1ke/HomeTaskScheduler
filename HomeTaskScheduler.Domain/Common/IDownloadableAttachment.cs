namespace HomeTaskScheduler.Domain.Common;

public interface IDownloadableAttachment
{
    int? Width { get; set; }
    int? Height { get; set; }
    string Path { get; set; }
    long FileSize { get; set; }
    string ContentType { get; set; }
    string Extension { get; set; }

    public string ThumbnailPath { get; set; }
}