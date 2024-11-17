using HomeTaskScheduler.Application.DTO.Attachments;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Attachment.Requests.Commands;

public class CreateFileAttachmentCommand : UserRequest, IRequest<Unit> 
{
    public CreateFileAttachmentDto FileAttachment { get; set; }
}