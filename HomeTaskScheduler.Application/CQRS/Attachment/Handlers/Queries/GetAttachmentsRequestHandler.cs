using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Attachment.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Attachments;

namespace HomeTaskScheduler.Application.CQRS.Attachment.Handlers.Queries;

public class GetAllAttachmentRequestHandler : IRequestHandler<GetAllAttachmentRequest, IReadOnlyList<AttachmentListDto>>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetAllAttachmentRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<IReadOnlyList<AttachmentListDto>> Handle(GetAllAttachmentRequest request, CancellationToken cancellationToken)
    {
        var attachments = await unitOfWork.AttachmentRepository.GetAllAsync();
        var attachmentDtos = mapper.Map<List<AttachmentListDto>>(attachments);

        return attachmentDtos;
    }
}


