using MediatR;
using HomeTaskScheduler.Application.CQRS.Theme.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Theme.Handlers.Commands;

public class UpdateThemeCommandHandler : IRequestHandler<UpdateThemeCommand, Unit>
{
    public async Task<Unit> Handle(UpdateThemeCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
