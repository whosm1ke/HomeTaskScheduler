using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Submissions;

public class CreateQuestionSubmissionDto : CreateSubmissionDto
{
    internal SubmissionType SubmissionType => SubmissionType.QuestionSubmission;
    
    public string? Answer { get; set; }

    public uint? AnswerId { get; set; }
}