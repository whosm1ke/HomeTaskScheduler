using HomeTaskScheduler.Application.DTO.Common;

namespace HomeTaskScheduler.Application.DTO.Attachments;

public class LinkAttachmentDto : AbstractAttachmentDto
{
    public string Url { get; set; }
}