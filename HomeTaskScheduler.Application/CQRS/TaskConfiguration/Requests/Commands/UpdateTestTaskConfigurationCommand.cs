using HomeTaskScheduler.Application.DTO.Tasks;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Commands;

public class UpdateTestTaskConfigurationCommand : UserRequest, IRequest<Unit> 
{
    public UpdateTestTaskConfigurationDto TestTask { get; set; }
}