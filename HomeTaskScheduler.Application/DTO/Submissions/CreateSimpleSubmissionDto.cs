using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Submissions;

public class CreateSimpleSubmissionDto : CreateSubmissionDto
{
    internal SubmissionType SubmissionType => SubmissionType.SimpleSubmission;
}