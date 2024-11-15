using MediatR;
using HomeTaskScheduler.Application.CQRS.Submission.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Submission.Handlers.Commands;

public class CreateSubmissionCommandHandler : IRequestHandler<CreateSubmissionCommand, Unit>
{
    public async Task<Unit> Handle(CreateSubmissionCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
