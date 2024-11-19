using HomeTaskScheduler.Application.DTO.Users;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Teacher.Requests.Queries;

public class GetAllTeachersRequest : UserRequest, IRequest<IReadOnlyList<UserListDto>>
{
    public Guid CourseId { get; set; }
}
