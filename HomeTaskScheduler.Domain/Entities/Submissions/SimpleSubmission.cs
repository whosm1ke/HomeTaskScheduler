using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Domain.Entities.Submissions;

public class SimpleSubmission : AbstractSubmission
{
    public SimpleSubmission()
    {
        SubmissionType = SubmissionType.SimpleSubmission;
    }
}