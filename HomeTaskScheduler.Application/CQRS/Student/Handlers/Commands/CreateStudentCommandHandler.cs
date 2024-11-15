using MediatR;
using HomeTaskScheduler.Application.CQRS.Student.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Student.Handlers.Commands;

public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, Unit>
{
    public async Task<Unit> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
