using HomeTaskScheduler.Application.DTO.Attachments;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Attachment.Requests.Queries;

public class GetLinkAttachmentRequest : UserRequest, IRequest<LinkAttachmentDto>
{
    public Guid Id { get; set; }
}