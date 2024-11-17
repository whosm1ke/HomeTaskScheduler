using HomeTaskScheduler.Application.DTO.Users;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Teacher.Requests.Commands;

public class UpdateTeacherCommand : UserRequest, IRequest<Unit>
{
    public UpdateUserDto Teacher { get; set; }
}
