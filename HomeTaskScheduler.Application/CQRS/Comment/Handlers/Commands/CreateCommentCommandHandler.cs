using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Comment.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Comment.Handlers.Commands;

public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public CreateCommentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
    {
        var comment = mapper.Map<Domain.Entities.Feed.Comment>(request.Comment);

        await unitOfWork.CommentRepository.AddAsync(comment);
        
        return Unit.Value;
    }
}
