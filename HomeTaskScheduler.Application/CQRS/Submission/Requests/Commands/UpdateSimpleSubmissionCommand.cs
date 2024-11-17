using HomeTaskScheduler.Application.DTO.Submissions;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Submission.Requests.Commands;

public class UpdateSimpleSubmissionCommand : UserRequest, IRequest<Unit> 
{
    public UpdateSimpleSubmissionDto SimpleSubmission { get; set; }
}