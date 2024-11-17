using MediatR;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Commands;

public class DeleteTaskConfigurationCommand : UserRequest, IRequest<Unit>
{
    public Guid Id { get; set; }
}
