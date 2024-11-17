using HomeTaskScheduler.Application.DTO.Users;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Teacher.Requests.Commands;

public class CreateTeacherCommand : UserRequest, IRequest<Unit>
{
    public CreateUserDto Teacher { get; set; }
}
