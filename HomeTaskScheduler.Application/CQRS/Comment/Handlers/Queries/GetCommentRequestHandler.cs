using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Comment.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Feed;

namespace HomeTaskScheduler.Application.CQRS.Comment.Handlers.Queries;

public class GetCommentRequestHandler : IRequestHandler<GetCommentRequest, CommentDto>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetCommentRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<CommentDto> Handle(GetCommentRequest request, CancellationToken cancellationToken)
    {
        var comment = await unitOfWork.CommentRepository.GetCommentByIdAsync(request.Id);

        return mapper.Map<CommentDto>(comment);
    }
}
