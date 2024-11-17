using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Student.Requests.Commands;

public class DeleteStudentCommand : UserRequest, IRequest<Unit>
{
    public Guid Id { get; set; }
}
