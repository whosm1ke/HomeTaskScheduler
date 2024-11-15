using MediatR;
using HomeTaskScheduler.Application.CQRS.Course.Requests.Queries;

namespace HomeTaskScheduler.Application.CQRS.Course.Handlers.Queries;

public class GetCourseRequestHandler : IRequestHandler<GetCourseRequest, Unit>
{
    public async Task<Unit> Handle(GetCourseRequest request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
