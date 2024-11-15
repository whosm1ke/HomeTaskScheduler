using MediatR;
using HomeTaskScheduler.Application.CQRS.Theme.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Theme.Handlers.Commands;

public class CreateThemeCommandHandler : IRequestHandler<CreateThemeCommand, Unit>
{
    public async Task<Unit> Handle(CreateThemeCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
