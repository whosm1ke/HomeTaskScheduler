using MediatR;
using HomeTaskScheduler.Application.CQRS.Attachment.Requests.Queries;

namespace HomeTaskScheduler.Application.CQRS.Attachment.Handlers.Queries;

public class GetAttachmentRequestHandler : IRequestHandler<GetAttachmentRequest, Unit>
{
    public async Task<Unit> Handle(GetAttachmentRequest request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
