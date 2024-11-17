using HomeTaskScheduler.Application.DTO.Users;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Teacher.Requests.Queries;

public class GetTeacherRequest : UserRequest, IRequest<TeacherDto>
{
    public Guid Id { get; set; }
}
