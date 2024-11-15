using MediatR;
using HomeTaskScheduler.Application.CQRS.Theme.Requests.Queries;

namespace HomeTaskScheduler.Application.CQRS.Theme.Handlers.Queries;

public class GetThemeRequestHandler : IRequestHandler<GetThemeRequest, Unit>
{
    public async Task<Unit> Handle(GetThemeRequest request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
