using HomeTaskScheduler.Application.DTO.Users;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Student.Requests.Commands;

public class CreateStudentCommand : UserRequest, IRequest<Unit>
{
    public CreateUserDto Student { get; set; }
}
