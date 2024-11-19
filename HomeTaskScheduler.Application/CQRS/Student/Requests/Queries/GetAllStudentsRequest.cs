using HomeTaskScheduler.Application.DTO.Users;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Student.Requests.Queries;

public class GetAllStudentsRequest : UserRequest, IRequest<IReadOnlyList<UserListDto>>
{
    public Guid CourseId { get; set; }
}
