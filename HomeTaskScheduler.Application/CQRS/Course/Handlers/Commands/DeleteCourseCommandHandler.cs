using MediatR;
using HomeTaskScheduler.Application.CQRS.Course.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Course.Handlers.Commands;

public class DeleteCourseCommandHandler : IRequestHandler<DeleteCourseCommand, Unit>
{
    public async Task<Unit> Handle(DeleteCourseCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
