using MediatR;
using HomeTaskScheduler.Application.CQRS.Course.Requests.Queries;

namespace HomeTaskScheduler.Application.CQRS.Course.Handlers.Queries;

public class GetAllCourseRequestHandler : IRequestHandler<GetAllCourseRequest, Unit>
{
    public async Task<Unit> Handle(GetAllCourseRequest request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
