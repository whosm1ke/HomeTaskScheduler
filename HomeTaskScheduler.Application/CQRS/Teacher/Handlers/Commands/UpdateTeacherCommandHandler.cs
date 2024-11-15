using MediatR;
using HomeTaskScheduler.Application.CQRS.Teacher.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Teacher.Handlers.Commands;

public class UpdateTeacherCommandHandler : IRequestHandler<UpdateTeacherCommand, Unit>
{
    public async Task<Unit> Handle(UpdateTeacherCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
