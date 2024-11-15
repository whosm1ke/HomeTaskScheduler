using MediatR;
using HomeTaskScheduler.Application.CQRS.Student.Requests.Queries;

namespace HomeTaskScheduler.Application.CQRS.Student.Handlers.Queries;

public class GetStudentRequestHandler : IRequestHandler<GetStudentRequest, Unit>
{
    public async Task<Unit> Handle(GetStudentRequest request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
