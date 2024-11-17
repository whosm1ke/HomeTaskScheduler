using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.CQRS.Attachment.Requests.Commands;
using HomeTaskScheduler.Domain.Entities.Attachments;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Attachment.Handlers.Commands;

public class CreateLinkAttachmentCommandHandler : IRequestHandler<CreateLinkAttachmentCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public CreateLinkAttachmentCommandHandler(
        IUnitOfWork unitOfWork, 
        IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async Task<Unit> Handle(CreateLinkAttachmentCommand request, CancellationToken cancellationToken)
    {
        var linkAttachment = mapper.Map<LinkAttachment>(request.LinkAttachment);
 
        await unitOfWork.AttachmentRepository.AddAsync(linkAttachment);
        await unitOfWork.SaveAsync();

        return Unit.Value;
    }
}