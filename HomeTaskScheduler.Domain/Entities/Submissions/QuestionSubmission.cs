using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Domain.Entities.Submissions;

public class QuestionSubmission : AbstractSubmission
{
    public QuestionSubmission()
    {
        SubmissionType = SubmissionType.QuestionSubmission;
    }
    
    public string Answer { get; set; }

    public uint AnswerId { get; set; }
}