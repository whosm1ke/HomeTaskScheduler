using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Comment.Requests.Commands;

public class DeleteCommentCommand : UserRequest, IRequest<Unit>
{
    public Guid Id { get; set; }
}
