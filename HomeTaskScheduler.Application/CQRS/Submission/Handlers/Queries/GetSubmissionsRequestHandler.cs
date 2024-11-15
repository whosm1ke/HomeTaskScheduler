using MediatR;
using HomeTaskScheduler.Application.CQRS.Submission.Requests.Queries;

namespace HomeTaskScheduler.Application.CQRS.Submission.Handlers.Queries;

public class GetAllSubmissionRequestHandler : IRequestHandler<GetAllSubmissionRequest, Unit>
{
    public async Task<Unit> Handle(GetAllSubmissionRequest request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
