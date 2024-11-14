using HomeTaskScheduler.Domain.Common;

namespace HomeTaskScheduler.Domain.Entities.Attachments;

public class VideoAttachment : AbstractAttachment,IDownloadableAttachment
{
    public long? DurationInSeconds { get; set; }
    public int? Width { get; set; }
    public int? Height { get; set; }
    public string Path { get; set; }
    public long FileSize { get; set; }
    public string ContentType { get; set; }
    public string Extension { get; set; }
}