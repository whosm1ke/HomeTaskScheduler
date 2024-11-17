using HomeTaskScheduler.Application.DTO.Tasks;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Commands;

public class CreateQuestionTaskConfigurationCommand : UserRequest, IRequest<Unit> 
{
    public CreateQuestionTaskConfigurationDto QuestionTask { get; set; }
}