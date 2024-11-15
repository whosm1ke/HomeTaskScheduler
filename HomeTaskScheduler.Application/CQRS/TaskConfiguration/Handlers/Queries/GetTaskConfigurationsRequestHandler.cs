using MediatR;
using HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Queries;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Handlers.Queries;

public class GetAllTaskConfigurationRequestHandler : IRequestHandler<GetAllTaskConfigurationRequest, Unit>
{
    public async Task<Unit> Handle(GetAllTaskConfigurationRequest request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
