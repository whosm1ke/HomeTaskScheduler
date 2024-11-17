using HomeTaskScheduler.Application.DTO.Attachments;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Attachment.Requests.Commands;

public class CreateVideoAttachmentCommand : UserRequest, IRequest<Unit> 
{
    public CreateVideoAttachmentDto VideoAttachment { get; set; }
}