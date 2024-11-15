using MediatR;
using HomeTaskScheduler.Application.CQRS.Theme.Requests.Queries;

namespace HomeTaskScheduler.Application.CQRS.Theme.Handlers.Queries;

public class GetAllThemeRequestHandler : IRequestHandler<GetAllThemeRequest, Unit>
{
    public async Task<Unit> Handle(GetAllThemeRequest request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
