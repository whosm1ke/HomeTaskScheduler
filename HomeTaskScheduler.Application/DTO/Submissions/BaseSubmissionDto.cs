namespace HomeTaskScheduler.Application.DTO.Submissions;

public abstract class BaseSubmissionDto
{
    public ICollection<Guid>? AttachmentIds { get; set; }
    public uint? Grade { get; set; }
    public Guid TaskConfigurationId { get; set; }
}