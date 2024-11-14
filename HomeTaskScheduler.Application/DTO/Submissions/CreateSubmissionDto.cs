using HomeTaskScheduler.Application.DTO.Common;

namespace HomeTaskScheduler.Application.DTO.Submissions;

public abstract class CreateSubmissionDto : ICommonSubmissionDto
{
    public Guid StudentId { get; set; }
    public ICollection<Guid>? AttachmentIds { get; set; }
    public uint? Grade { get; set; }
    public Guid TaskConfigurationId { get; set; }
}