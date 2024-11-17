using HomeTaskScheduler.Application.DTO.Feed;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Comment.Requests.Commands;

public class CreateCommentCommand : UserRequest, IRequest<Unit>
{
    public CreateCommentDto Comment { get; set; }
}
