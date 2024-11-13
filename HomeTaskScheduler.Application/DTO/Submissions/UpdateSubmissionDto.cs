using HomeTaskScheduler.Application.DTO.Common;

namespace HomeTaskScheduler.Application.DTO.Submissions;

public abstract class UpdateSubmissionDto : BaseSubmissionDto, IEntity
{
    public Guid Id { get; set; }
}