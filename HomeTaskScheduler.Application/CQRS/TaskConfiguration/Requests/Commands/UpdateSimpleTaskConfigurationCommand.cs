using HomeTaskScheduler.Application.DTO.Tasks;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Commands;

public class UpdateSimpleTaskConfigurationCommand : UserRequest, IRequest<Unit> 
{
    public UpdateSimpleTaskConfigurationDto SimpleTask { get; set; }
}