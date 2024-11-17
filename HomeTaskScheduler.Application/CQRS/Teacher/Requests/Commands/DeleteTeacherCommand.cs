using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Teacher.Requests.Commands;

public class DeleteTeacherCommand : UserRequest, IRequest<Unit>
{
    public Guid Id { get; set; }
}
