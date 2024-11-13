using HomeTaskScheduler.Application.DTO.Common;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Submissions;

public class SimpleSubmissionDto : AbstractSubmissionDto
{
    public SimpleSubmissionDto()
    {
        SubmissionType = SubmissionType.SimpleSubmission;
    }
}