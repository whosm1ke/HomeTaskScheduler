using MediatR;
using HomeTaskScheduler.Application.CQRS.Comment.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Comment.Handlers.Commands;

public class UpdateCommentCommandHandler : IRequestHandler<UpdateCommentCommand, Unit>
{
    public async Task<Unit> Handle(UpdateCommentCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
