using HomeTaskScheduler.Application.DTO.Tasks;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Commands;

public class UpdateQuestionTaskConfigurationCommand : UserRequest, IRequest<Unit> 
{
    public UpdateQuestionTaskConfigurationDto QuestionTask { get; set; }
}