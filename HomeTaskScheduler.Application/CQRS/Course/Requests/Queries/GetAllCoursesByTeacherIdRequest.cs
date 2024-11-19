using HomeTaskScheduler.Application.DTO.Feed;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Course.Requests.Queries;

public class GetAllCoursesByTeacherIdRequest : UserRequest, IRequest<IReadOnlyList<CourseListDto>>
{
    public Guid TeacherId { get; set; }
}