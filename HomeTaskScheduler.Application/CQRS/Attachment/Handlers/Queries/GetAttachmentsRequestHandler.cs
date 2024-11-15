using MediatR;
using HomeTaskScheduler.Application.CQRS.Attachment.Requests.Queries;

namespace HomeTaskScheduler.Application.CQRS.Attachment.Handlers.Queries;

public class GetAllAttachmentRequestHandler : IRequestHandler<GetAllAttachmentRequest, Unit>
{
    public async Task<Unit> Handle(GetAllAttachmentRequest request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
