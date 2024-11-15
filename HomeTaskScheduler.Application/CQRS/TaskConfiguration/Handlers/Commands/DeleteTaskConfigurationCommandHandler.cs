using MediatR;
using HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Handlers.Commands;

public class DeleteTaskConfigurationCommandHandler : IRequestHandler<DeleteTaskConfigurationCommand, Unit>
{
    public async Task<Unit> Handle(DeleteTaskConfigurationCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
