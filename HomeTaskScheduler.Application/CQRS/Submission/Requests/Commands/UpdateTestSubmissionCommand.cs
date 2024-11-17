using HomeTaskScheduler.Application.DTO.Submissions;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Submission.Requests.Commands;

public class UpdateTestSubmissionCommand : UserRequest, IRequest<Unit> 
{
    public UpdateTestSubmissionDto TestSubmission { get; set; }
}