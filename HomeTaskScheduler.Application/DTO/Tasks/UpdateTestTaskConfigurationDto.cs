using HomeTaskScheduler.Domain.ValueTypes;

namespace HomeTaskScheduler.Application.DTO.Tasks;

public class UpdateTestTaskConfigurationDto : UpdateTaskConfigurationDto
{
    public virtual ICollection<QuestionAnswer> QuestionsAnswers { get; set; }
}