using HomeTaskScheduler.Application.DTO.Feed;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Comment.Requests.Queries;

    public class GetAllCommentRequest : UserRequest, IRequest<IReadOnlyList<CommentDto>>;
