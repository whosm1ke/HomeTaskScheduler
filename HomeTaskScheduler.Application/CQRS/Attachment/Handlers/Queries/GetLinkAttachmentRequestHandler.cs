using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.CQRS.Attachment.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Attachments;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Attachment.Handlers.Queries;

public class GetLinkAttachmentRequestHandler : IRequestHandler<GetLinkAttachmentRequest, LinkAttachmentDto>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetLinkAttachmentRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async Task<LinkAttachmentDto> Handle(GetLinkAttachmentRequest request, CancellationToken cancellationToken)
    {
        var linkAttachment = await unitOfWork.AttachmentRepository.GetLinkAttachmentByIdAsync(request.Id);

        return mapper.Map<LinkAttachmentDto>(linkAttachment);

    }
}