using HomeTaskScheduler.Application.DTO.Attachments;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Attachment.Requests.Queries;

public class GetVideoAttachmentRequest : UserRequest, IRequest<VideoAttachmentDto>
{
    public Guid Id { get; set; }
}