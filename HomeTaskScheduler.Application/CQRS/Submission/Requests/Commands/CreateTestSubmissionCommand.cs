using HomeTaskScheduler.Application.DTO.Submissions;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Submission.Requests.Commands;

public class CreateTestSubmissionCommand : UserRequest, IRequest<Unit>
{
    public CreateTestSubmissionDto TestSubmission { get; set; }
}