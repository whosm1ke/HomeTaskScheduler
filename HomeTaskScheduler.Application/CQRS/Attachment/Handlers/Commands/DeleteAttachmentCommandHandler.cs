using MediatR;
using HomeTaskScheduler.Application.CQRS.Attachment.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Attachment.Handlers.Commands;

public class DeleteAttachmentCommandHandler : IRequestHandler<DeleteAttachmentCommand, Unit>
{
    public async Task<Unit> Handle(DeleteAttachmentCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
