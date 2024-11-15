using MediatR;
using HomeTaskScheduler.Application.CQRS.Comment.Requests.Queries;

namespace HomeTaskScheduler.Application.CQRS.Comment.Handlers.Queries;

public class GetCommentRequestHandler : IRequestHandler<GetCommentRequest, Unit>
{
    public async Task<Unit> Handle(GetCommentRequest request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
