using HomeTaskScheduler.Application.DTO.Attachments;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Attachment.Requests.Queries;

public class GetAllAttachmentRequest : UserRequest, IRequest<IReadOnlyList<AttachmentListDto>>;
