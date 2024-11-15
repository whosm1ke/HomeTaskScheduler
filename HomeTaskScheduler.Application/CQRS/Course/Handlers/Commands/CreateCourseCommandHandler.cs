using MediatR;
using HomeTaskScheduler.Application.CQRS.Course.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Course.Handlers.Commands;

public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, Unit>
{
    public async Task<Unit> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
