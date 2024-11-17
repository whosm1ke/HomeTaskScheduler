using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Submission.Requests.Commands;

public class DeleteSubmissionCommand : UserRequest, IRequest<Unit>
{
    public Guid Id { get; set; }
}
