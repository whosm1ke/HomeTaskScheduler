using MediatR;
using HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Handlers.Commands;

public class CreateTaskConfigurationCommandHandler : IRequestHandler<CreateTaskConfigurationCommand, Unit>
{
    public async Task<Unit> Handle(CreateTaskConfigurationCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
