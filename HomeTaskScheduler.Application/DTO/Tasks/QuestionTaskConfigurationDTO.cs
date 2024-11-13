using HomeTaskScheduler.Application.DTO.Common;
using HomeTaskScheduler.Domain.Enums;
using HomeTaskScheduler.Domain.ValueTypes;

namespace HomeTaskScheduler.Application.DTO.Tasks;

public class QuestionTaskConfigurationDto : AbstractTaskConfigurationDto
{
    public QuestionAnswer? QuestionAnswer { get; set; }
    public string? Answer { get; set; }
    public AnswerUnit AnswerUnit { get; set; }
}