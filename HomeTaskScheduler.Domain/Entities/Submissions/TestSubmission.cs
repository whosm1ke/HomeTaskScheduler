using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Domain.Entities.Submissions;

public class TestSubmission : AbstractSubmission
{
    public TestSubmission()
    {
        SubmissionType = SubmissionType.TestSubmission;
    }
    public uint AnswerId { get; set; }
}