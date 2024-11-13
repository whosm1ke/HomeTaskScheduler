using HomeTaskScheduler.Domain.ValueTypes;

namespace HomeTaskScheduler.Application.DTO.Tasks;

public class CreateTestTaskConfigurationDto : CreateTaskConfigurationDto
{
    public virtual ICollection<QuestionAnswer> QuestionsAnswers { get; set; }
}