namespace HomeTaskScheduler.Application.DTO.Attachments;

public abstract class CreateAttachmentDto 
{
    public string AttachmentName { get; set; }
    public Guid? SubmissionId { get; set; }
    public Guid? TaskConfigurationId { get; set; }
}