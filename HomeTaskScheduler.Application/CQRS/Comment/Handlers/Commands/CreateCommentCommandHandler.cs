using MediatR;
using HomeTaskScheduler.Application.CQRS.Comment.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Comment.Handlers.Commands;

public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, Unit>
{
    public async Task<Unit> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
