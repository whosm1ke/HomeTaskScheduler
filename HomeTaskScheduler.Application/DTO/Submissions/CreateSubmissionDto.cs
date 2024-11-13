namespace HomeTaskScheduler.Application.DTO.Submissions;

public abstract class CreateSubmissionDto : BaseSubmissionDto
{
    public Guid StudentId { get; set; }
}