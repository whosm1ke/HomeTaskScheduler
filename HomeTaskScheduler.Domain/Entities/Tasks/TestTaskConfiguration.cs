using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Enums;
using HomeTaskScheduler.Domain.ValueTypes;

namespace HomeTaskScheduler.Domain.Entities.Tasks;

public class TestTaskConfiguration : AbstractTaskConfiguration
{
    public TestTaskConfiguration()
    {
        TaskType = TaskType.TestTask;
    }
    public virtual ICollection<QuestionAnswer> QuestionsAnswers { get; set; }
}