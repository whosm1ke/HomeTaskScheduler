namespace HomeTaskScheduler.Application.DTO.Common;

public interface ICommonAttachment
{
    public string AttachmentName { get; set; }
    public Guid? SubmissionId { get; set; }
    public Guid? TaskConfigurationId { get; set; }
}