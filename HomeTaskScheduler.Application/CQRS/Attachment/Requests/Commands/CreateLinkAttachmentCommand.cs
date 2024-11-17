using HomeTaskScheduler.Application.DTO.Attachments;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Attachment.Requests.Commands;

public class CreateLinkAttachmentCommand : UserRequest, IRequest<Unit> 
{
    public CreateLinkAttachmentDto LinkAttachment { get; set; }
}