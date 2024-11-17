using HomeTaskScheduler.Application.DTO.Feed;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Course.Requests.Queries;

    public class GetAllCourseRequest : UserRequest, IRequest<IReadOnlyList<CourseListDto>>;
