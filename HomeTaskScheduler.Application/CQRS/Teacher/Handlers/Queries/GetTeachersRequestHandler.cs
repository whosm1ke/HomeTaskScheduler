using MediatR;
using HomeTaskScheduler.Application.CQRS.Teacher.Requests.Queries;

namespace HomeTaskScheduler.Application.CQRS.Teacher.Handlers.Queries;

public class GetAllTeacherRequestHandler : IRequestHandler<GetAllTeacherRequest, Unit>
{
    public async Task<Unit> Handle(GetAllTeacherRequest request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
