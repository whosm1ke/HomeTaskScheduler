using HomeTaskScheduler.Application.DTO.Tasks;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Commands;

public class CreateTestTaskConfigurationCommand : UserRequest, IRequest<Unit> 
{
    public CreateTestTaskConfigurationDto TestTask { get; set; }
}