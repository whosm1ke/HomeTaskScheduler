namespace HomeTaskScheduler.Application.DTO.Submissions;

public class UpdateTestSubmissionDto : UpdateSubmissionDto
{
    
    public ICollection<uint> AnswerIds { get; set; }
}