using MediatR;
using HomeTaskScheduler.Application.CQRS.Teacher.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Teacher.Handlers.Commands;

public class DeleteTeacherCommandHandler : IRequestHandler<DeleteTeacherCommand, Unit>
{
    public async Task<Unit> Handle(DeleteTeacherCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
