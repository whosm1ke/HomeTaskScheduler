using MediatR;
using HomeTaskScheduler.Application.CQRS.Attachment.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Attachment.Handlers.Commands;

public class UpdateAttachmentCommandHandler : IRequestHandler<UpdateAttachmentCommand, Unit>
{
    public async Task<Unit> Handle(UpdateAttachmentCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
