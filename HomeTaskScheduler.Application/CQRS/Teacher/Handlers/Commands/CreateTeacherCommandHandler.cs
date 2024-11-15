using MediatR;
using HomeTaskScheduler.Application.CQRS.Teacher.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Teacher.Handlers.Commands;

public class CreateTeacherCommandHandler : IRequestHandler<CreateTeacherCommand, Unit>
{
    public async Task<Unit> Handle(CreateTeacherCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
