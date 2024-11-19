using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.CQRS.Comment.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Feed;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Comment.Handlers.Queries;

public class GetAllCommentsByTaskIdHandler : IRequestHandler<GetAllCommentsByTaskIdRequest, IReadOnlyList<CommentDto>>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetAllCommentsByTaskIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<IReadOnlyList<CommentDto>> Handle(GetAllCommentsByTaskIdRequest request, CancellationToken cancellationToken)
    {
        var comments = await unitOfWork.CommentRepository.GetAllCommentsByTaskIdAsync(request.TaskId);
        
        return mapper.Map<List<CommentDto>>(comments);
    }
}