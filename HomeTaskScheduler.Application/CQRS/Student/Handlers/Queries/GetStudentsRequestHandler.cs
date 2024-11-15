using MediatR;
using HomeTaskScheduler.Application.CQRS.Student.Requests.Queries;

namespace HomeTaskScheduler.Application.CQRS.Student.Handlers.Queries;

public class GetAllStudentRequestHandler : IRequestHandler<GetAllStudentRequest, Unit>
{
    public async Task<Unit> Handle(GetAllStudentRequest request, CancellationToken cancellationToken)
    {
        return Unit.Value;
    }
}
