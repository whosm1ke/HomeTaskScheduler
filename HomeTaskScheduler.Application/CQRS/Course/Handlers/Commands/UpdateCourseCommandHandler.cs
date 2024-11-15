using MediatR;
using HomeTaskScheduler.Application.CQRS.Course.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Course.Handlers.Commands;

public class UpdateCourseCommandHandler : IRequestHandler<UpdateCourseCommand, Unit>
{
    public async Task<Unit> Handle(UpdateCourseCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
