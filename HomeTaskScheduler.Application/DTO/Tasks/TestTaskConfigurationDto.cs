using HomeTaskScheduler.Application.DTO.Common;
using HomeTaskScheduler.Domain.ValueTypes;

namespace HomeTaskScheduler.Application.DTO.Tasks;

public class TestTaskConfigurationDto : AbstractTaskConfigurationDto
{
    public virtual ICollection<QuestionAnswer> QuestionsAnswers { get; set; }
}