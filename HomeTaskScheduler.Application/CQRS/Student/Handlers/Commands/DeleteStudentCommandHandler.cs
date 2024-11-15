using MediatR;
using HomeTaskScheduler.Application.CQRS.Student.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Student.Handlers.Commands;

public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand, Unit>
{
    public async Task<Unit> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
