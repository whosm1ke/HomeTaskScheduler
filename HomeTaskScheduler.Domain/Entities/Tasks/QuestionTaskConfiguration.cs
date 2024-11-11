using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Enums;
using HomeTaskScheduler.Domain.ValueTypes;

namespace HomeTaskScheduler.Domain.Entities.Tasks;

public class QuestionTaskConfiguration : AbstractTaskConfiguration
{
    public QuestionAnswer? QuestionAnswer { get; set; }
    public string Answer { get; set; }
    public AnswerUnit AnswerUnit { get; set; }
}