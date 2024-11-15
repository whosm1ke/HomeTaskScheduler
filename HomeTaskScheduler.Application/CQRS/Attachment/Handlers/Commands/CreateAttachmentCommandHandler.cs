using MediatR;
using HomeTaskScheduler.Application.CQRS.Attachment.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Attachment.Handlers.Commands;

public class CreateAttachmentCommandHandler : IRequestHandler<CreateAttachmentCommand, Unit>
{
    public async Task<Unit> Handle(CreateAttachmentCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
