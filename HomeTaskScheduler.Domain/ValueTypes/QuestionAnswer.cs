namespace HomeTaskScheduler.Domain.ValueTypes;

public class QuestionAnswer
{
    public string Question { get; set; }

    public uint CorrectAnswerId { get; set; }

    public ICollection<string> Answers { get; set; }
}