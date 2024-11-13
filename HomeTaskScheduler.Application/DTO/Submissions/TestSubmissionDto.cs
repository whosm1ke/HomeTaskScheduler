using HomeTaskScheduler.Application.DTO.Common;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Submissions;

public class TestSubmissionDto : AbstractSubmissionDto
{
    public TestSubmissionDto()
    {
        SubmissionType = SubmissionType.TestSubmission;
    }
    public uint AnswerId { get; set; }
}