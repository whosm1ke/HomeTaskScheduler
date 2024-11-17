using HomeTaskScheduler.Application.DTO.Tasks;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Commands;

public class CreateSimpleTaskConfigurationCommand : UserRequest, IRequest<Unit> 
{
    public CreateSimpleTaskConfigurationDto SimpleTask { get; set; }
}