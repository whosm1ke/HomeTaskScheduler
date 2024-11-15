using MediatR;
using HomeTaskScheduler.Application.CQRS.Teacher.Requests.Queries;

namespace HomeTaskScheduler.Application.CQRS.Teacher.Handlers.Queries;

public class GetTeacherRequestHandler : IRequestHandler<GetTeacherRequest, Unit>
{
    public async Task<Unit> Handle(GetTeacherRequest request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
