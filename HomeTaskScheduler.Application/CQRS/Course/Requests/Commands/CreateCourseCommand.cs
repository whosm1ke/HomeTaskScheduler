using HomeTaskScheduler.Application.DTO.Feed;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Course.Requests.Commands;

public class CreateCourseCommand : UserRequest, IRequest<Unit>
{
    public CreateCourseDto Course { get; set; }
}
