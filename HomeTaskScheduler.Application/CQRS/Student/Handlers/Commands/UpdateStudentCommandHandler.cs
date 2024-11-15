using MediatR;
using HomeTaskScheduler.Application.CQRS.Student.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Student.Handlers.Commands;

public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand, Unit>
{
    public async Task<Unit> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
