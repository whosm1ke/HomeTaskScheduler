using HomeTaskScheduler.Application.DTO.Common;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Submissions;

public class TestSubmissionDto : AbstractSubmissionDto
{
    public TestSubmissionDto()
    {
        SubmissionType = SubmissionType.TestSubmission;
    }
    public ICollection<uint> AnswerIds { get; set; }
}