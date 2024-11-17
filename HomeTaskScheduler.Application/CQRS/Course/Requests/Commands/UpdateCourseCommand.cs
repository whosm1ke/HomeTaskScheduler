using HomeTaskScheduler.Application.DTO.Feed;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Course.Requests.Commands;

public class UpdateCourseCommand : UserRequest, IRequest<Unit>
{
    public UpdateCourseDto Course { get; set; }
}
