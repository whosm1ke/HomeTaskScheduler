using MediatR;
using HomeTaskScheduler.Application.CQRS.Comment.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Comment.Handlers.Commands;

public class DeleteCommentCommandHandler : IRequestHandler<DeleteCommentCommand, Unit>
{
    public async Task<Unit> Handle(DeleteCommentCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
