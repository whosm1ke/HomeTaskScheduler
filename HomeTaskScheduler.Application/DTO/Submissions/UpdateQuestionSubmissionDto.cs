namespace HomeTaskScheduler.Application.DTO.Submissions;

public class UpdateQuestionSubmissionDto : UpdateSubmissionDto
{
    
    public string Answer { get; set; }

    public uint AnswerId { get; set; }
}