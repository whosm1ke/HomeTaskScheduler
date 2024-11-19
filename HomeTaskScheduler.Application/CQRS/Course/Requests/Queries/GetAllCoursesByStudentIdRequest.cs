using HomeTaskScheduler.Application.DTO.Feed;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Course.Requests.Queries;

public class GetAllCoursesByStudentIdRequest : UserRequest, IRequest<IReadOnlyList<CourseListDto>>
{
    public Guid StudentId { get; set; }
}