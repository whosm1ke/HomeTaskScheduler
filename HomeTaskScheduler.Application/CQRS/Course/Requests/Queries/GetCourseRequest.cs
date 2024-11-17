using HomeTaskScheduler.Application.DTO.Feed;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Course.Requests.Queries;

    public class GetCourseRequest : UserRequest, IRequest<CourseDto>
    {
        public Guid Id { get; set; }
    }
