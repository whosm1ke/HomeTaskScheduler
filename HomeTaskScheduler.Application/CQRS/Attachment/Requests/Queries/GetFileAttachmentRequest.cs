using HomeTaskScheduler.Application.DTO.Attachments;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Attachment.Requests.Queries;

public class GetFileAttachmentRequest : UserRequest, IRequest<FileAttachmentDto>
{
    public Guid Id { get; set; }
}