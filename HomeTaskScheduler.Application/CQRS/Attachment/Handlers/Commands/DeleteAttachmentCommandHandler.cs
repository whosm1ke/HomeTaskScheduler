using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Attachment.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Attachment.Handlers.Commands;

public class DeleteAttachmentCommandHandler : IRequestHandler<DeleteAttachmentCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public DeleteAttachmentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(DeleteAttachmentCommand request, CancellationToken cancellationToken)
    {
        var attachment = await unitOfWork.AttachmentRepository.GetAsyncNoTracking(request.Id);
        
        unitOfWork.AttachmentRepository.Delete(attachment);
        
        await unitOfWork.SaveAsync();
        return Unit.Value;
    }
}
