using MediatR;
using HomeTaskScheduler.Application.CQRS.Submission.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Submission.Handlers.Commands;

public class UpdateSubmissionCommandHandler : IRequestHandler<UpdateSubmissionCommand, Unit>
{
    public async Task<Unit> Handle(UpdateSubmissionCommand request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
