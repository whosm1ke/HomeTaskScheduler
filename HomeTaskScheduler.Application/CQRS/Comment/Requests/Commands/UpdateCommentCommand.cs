using HomeTaskScheduler.Application.DTO.Feed;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Comment.Requests.Commands;

public class UpdateCommentCommand : UserRequest, IRequest<Unit>
{
    public UpdateCommentDto Comment { get; set; }
}
