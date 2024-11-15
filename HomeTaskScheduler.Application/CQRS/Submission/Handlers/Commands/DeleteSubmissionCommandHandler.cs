using MediatR;
using HomeTaskScheduler.Application.CQRS.Submission.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Submission.Handlers.Commands;

public class DeleteSubmissionCommandHandler : IRequestHandler<DeleteSubmissionCommand, Unit>
{
    public async Task<Unit> Handle(DeleteSubmissionCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
