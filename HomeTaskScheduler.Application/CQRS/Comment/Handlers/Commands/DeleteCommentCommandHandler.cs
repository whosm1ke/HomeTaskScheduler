using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Comment.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Comment.Handlers.Commands;

public class DeleteCommentCommandHandler : IRequestHandler<DeleteCommentCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public DeleteCommentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async Task<Unit> Handle(DeleteCommentCommand request, CancellationToken cancellationToken)
    {
        var comment = await unitOfWork.CommentRepository.GetAsyncNoTracking(request.Id);
        
        unitOfWork.CommentRepository.Delete(comment);
        
        await unitOfWork.SaveAsync();
        return Unit.Value;
    }
}
