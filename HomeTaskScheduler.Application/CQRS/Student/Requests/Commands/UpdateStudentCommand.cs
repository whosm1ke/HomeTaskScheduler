using HomeTaskScheduler.Application.DTO.Users;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Student.Requests.Commands;

public class UpdateStudentCommand : UserRequest, IRequest<Unit>
{
    public UpdateUserDto Student { get; set; }
}
