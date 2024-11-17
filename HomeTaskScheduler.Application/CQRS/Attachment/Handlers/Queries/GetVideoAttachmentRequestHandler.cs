using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.CQRS.Attachment.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Attachments;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Attachment.Handlers.Queries;

public class GetVideoAttachmentRequestHandler : IRequestHandler<GetVideoAttachmentRequest, VideoAttachmentDto>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetVideoAttachmentRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async Task<VideoAttachmentDto> Handle(GetVideoAttachmentRequest request, CancellationToken cancellationToken)
    {
        var videoAttachment = await unitOfWork.AttachmentRepository.GetVideoAttachmentByIdAsync(request.Id);

        var videoAttachmentDto = mapper.Map<VideoAttachmentDto>(videoAttachment);

        return videoAttachmentDto;
    }
}