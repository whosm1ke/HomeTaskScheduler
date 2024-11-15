using MediatR;
using HomeTaskScheduler.Application.CQRS.Submission.Requests.Queries;

namespace HomeTaskScheduler.Application.CQRS.Submission.Handlers.Queries;

public class GetSubmissionRequestHandler : IRequestHandler<GetSubmissionRequest, Unit>
{
    public async Task<Unit> Handle(GetSubmissionRequest request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
