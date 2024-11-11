using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.ValueTypes;

namespace HomeTaskScheduler.Domain.Entities.Tasks;

public class TestTaskConfiguration : AbstractTaskConfiguration
{
    public virtual ICollection<QuestionAnswer> QuestionsAnswers { get; set; }
}