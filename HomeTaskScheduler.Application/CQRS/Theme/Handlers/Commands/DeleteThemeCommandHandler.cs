using MediatR;
using HomeTaskScheduler.Application.CQRS.Theme.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Theme.Handlers.Commands;

public class DeleteThemeCommandHandler : IRequestHandler<DeleteThemeCommand, Unit>
{
    public async Task<Unit> Handle(DeleteThemeCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
