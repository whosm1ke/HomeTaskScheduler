using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Attachment.Requests.Commands;

public class DeleteAttachmentCommand : UserRequest, IRequest<Unit>
{
    public Guid Id { get; set; }
}
