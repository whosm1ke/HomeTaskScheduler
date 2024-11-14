namespace HomeTaskScheduler.Application.DTO.Attachments;

public class CreateVideoAttachmentDto : CreateAttachmentDto
{
    public Stream FileStream { get; set; }
    public long? DurationInSeconds { get; set; }
}