using HomeTaskScheduler.Application.DTO.Submissions;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Submission.Requests.Commands;

public class CreateSimpleSubmissionCommand : UserRequest, IRequest<Unit>
{
    public CreateSimpleSubmissionDto SimpleSubmission { get; set; }
}