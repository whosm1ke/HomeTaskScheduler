using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Attachments;

public class AttachmentListDto
{
    public AttachmentType AttachmentType { get; set; }
    public string AttachmentName { get; set; }
    public Guid Id { get; set; }
    public string ThumbnailPath { get; set; }
    public string Url { get; set; }
}