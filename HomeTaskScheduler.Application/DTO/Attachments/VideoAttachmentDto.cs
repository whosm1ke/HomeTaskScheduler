using HomeTaskScheduler.Application.DTO.Common;

namespace HomeTaskScheduler.Application.DTO.Attachments;

public class VideoAttachmentDto : AbstractAttachmentDto, IDownloadableAttachmentDto
{
    public double? DurationInSeconds { get; set; }
    public int? Width { get; set; }
    public int? Height { get; set; }
    public string Path { get; set; }
    public long FileSize { get; set; }
    public string ContentType { get; set; }
    public string Extension { get; set; }
    public string ThumbnailPath { get; set; }
}