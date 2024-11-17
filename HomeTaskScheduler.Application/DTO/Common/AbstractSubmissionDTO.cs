using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Common;

public abstract class AbstractSubmissionDto : ICommonSubmissionDto
{
    public SubmissionStatus SubmissionStatus { get; set; }
    public SubmissionType SubmissionType { get; protected set; }
    public Guid StudentId { get; set; }
    public Guid Id { get; set; }
    public ICollection<Guid>? AttachmentIds { get; set; }
    public uint? Grade { get; set; }
    public Guid TaskConfigurationId { get; set; }
}
