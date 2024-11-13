using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Submissions;

public class CreateTestSubmissionDto : CreateSubmissionDto
{
    internal SubmissionType SubmissionType => SubmissionType.TestSubmission;
    
    public uint AnswerId { get; set; }
}