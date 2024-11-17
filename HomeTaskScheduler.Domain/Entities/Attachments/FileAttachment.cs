using HomeTaskScheduler.Domain.Common;

namespace HomeTaskScheduler.Domain.Entities.Attachments;

public class FileAttachment : AbstractAttachment, IDownloadableAttachment
{
    public int? Width { get; set; }
    public int? Height { get; set; }
    public string Path { get; set; }
    public long FileSize { get; set; }
    public string ContentType { get; set; }
    public string Extension { get; set; }
    public string ThumbnailPath { get; set; }
}