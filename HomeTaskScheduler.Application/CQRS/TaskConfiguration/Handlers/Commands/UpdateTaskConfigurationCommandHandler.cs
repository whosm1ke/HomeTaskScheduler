using MediatR;
using HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Handlers.Commands;

public class UpdateTaskConfigurationCommandHandler : IRequestHandler<UpdateTaskConfigurationCommand, Unit>
{
    public async Task<Unit> Handle(UpdateTaskConfigurationCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
