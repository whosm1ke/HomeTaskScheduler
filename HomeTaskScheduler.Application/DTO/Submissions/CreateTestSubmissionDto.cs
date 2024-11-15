using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Submissions;

public class CreateTestSubmissionDto : CreateSubmissionDto
{
    internal SubmissionType SubmissionType => SubmissionType.TestSubmission;
    
    public ICollection<uint> AnswerIds { get; set; }
}