namespace HomeTaskScheduler.Application.DTO.Common;

public interface ICommonSubmissionDto
{
    public ICollection<Guid>? AttachmentIds { get; set; }
    public uint? Grade { get; set; }
    public Guid TaskConfigurationId { get; set; }
}