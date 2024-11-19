using HomeTaskScheduler.Application.DTO.Feed;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Comment.Requests.Queries;

public class GetAllCommentsByCourseIdRequest : UserRequest, IRequest<IReadOnlyList<CommentDto>>
{
    public Guid CourseId { get; set; }
}

public class GetAllCommentsByTaskIdRequest : UserRequest, IRequest<IReadOnlyList<CommentDto>>
{
    public Guid TaskId { get; set; }
}