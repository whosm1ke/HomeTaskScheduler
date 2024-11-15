using MediatR;
using HomeTaskScheduler.Application.CQRS.Comment.Requests.Queries;

namespace HomeTaskScheduler.Application.CQRS.Comment.Handlers.Queries;

public class GetAllCommentRequestHandler : IRequestHandler<GetAllCommentRequest, Unit>
{
    public async Task<Unit> Handle(GetAllCommentRequest request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
