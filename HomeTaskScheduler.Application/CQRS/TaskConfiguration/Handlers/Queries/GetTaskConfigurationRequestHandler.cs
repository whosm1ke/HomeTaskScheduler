using MediatR;
using HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Queries;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Handlers.Queries;

public class GetTaskConfigurationRequestHandler : IRequestHandler<GetTaskConfigurationRequest, Unit>
{
    public async Task<Unit> Handle(GetTaskConfigurationRequest request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
