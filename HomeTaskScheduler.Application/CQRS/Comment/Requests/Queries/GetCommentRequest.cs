using HomeTaskScheduler.Application.DTO.Feed;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Comment.Requests.Queries;

    public class GetCommentRequest : UserRequest, IRequest<CommentDto>
    {
        public Guid Id { get; set; }
    }
