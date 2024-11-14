using HomeTaskScheduler.Application.DTO.Common;

namespace HomeTaskScheduler.Application.DTO.Attachments;

public class FileAttachmentDto : AbstractAttachmentDto, IDownloadableAttachmentDto
{
    public int? Width { get; set; }
    public int? Height { get; set; }
    public string Path { get; set; }
    public long FileSize { get; set; }
    public string ContentType { get; set; }
    public string Extension { get; set; }
    public byte[] ThumbnailBytes { get; set; }
}