namespace HomeTaskScheduler.Application.DTO.Attachments;

public class CreateFileAttachmentDto : CreateAttachmentDto
{
    public Stream FileStream { get; set; }
}