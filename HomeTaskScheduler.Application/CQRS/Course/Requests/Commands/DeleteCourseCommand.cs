using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Course.Requests.Commands;

public class DeleteCourseCommand : UserRequest, IRequest<Unit>
{
    public Guid Id { get; set; }
}
