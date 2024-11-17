using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Attachment.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Attachments;

namespace HomeTaskScheduler.Application.CQRS.Attachment.Handlers.Queries;

public class GetFileAttachmentRequestHandler : IRequestHandler<GetFileAttachmentRequest, FileAttachmentDto>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetFileAttachmentRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async Task<FileAttachmentDto> Handle(GetFileAttachmentRequest request, CancellationToken cancellationToken)
    {
        var fileAttachment = await unitOfWork.AttachmentRepository.GetFileAttachmentByIdAsync(request.Id);

        var fileAttachmentDto = mapper.Map<FileAttachmentDto>(fileAttachment);

        return fileAttachmentDto;
    }
}