using HomeTaskScheduler.Application.DTO.Common;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Submissions;

public class QuestionSubmissionDto : AbstractSubmissionDto
{
    public QuestionSubmissionDto()
    {
        SubmissionType = SubmissionType.QuestionSubmission;
    }
    
    public string Answer { get; set; }

    public uint AnswerId { get; set; }
}