using HomeTaskScheduler.Application.DTO.Common;

namespace HomeTaskScheduler.Application.DTO.Attachments;

public class CreateFileAttachmentDto : CreateAttachmentDto,ICreateDownloadableAttachmentDto
{
    public Stream FileStream { get; set; }
    public int? Width { get; set; }
    public int? Height { get; set; }
    public string ContentType { get; set; }
    public string Extension { get; set; }
}