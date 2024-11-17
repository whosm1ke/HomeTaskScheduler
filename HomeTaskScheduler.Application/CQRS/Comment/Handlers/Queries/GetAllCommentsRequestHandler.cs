using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Comment.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Feed;

namespace HomeTaskScheduler.Application.CQRS.Comment.Handlers.Queries;

public class GetAllCommentRequestHandler : IRequestHandler<GetAllCommentRequest, IReadOnlyList<CommentDto>>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetAllCommentRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<IReadOnlyList<CommentDto>> Handle(GetAllCommentRequest request, CancellationToken cancellationToken)
    {
        var comments = await unitOfWork.CommentRepository.GetAllAsync();
        
        return mapper.Map<List<CommentDto>>(comments);
    }
}
