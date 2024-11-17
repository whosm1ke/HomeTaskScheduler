using HomeTaskScheduler.Application.DTO.Submissions;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Submission.Requests.Commands;

public class UpdateQuestionSubmissionCommand : UserRequest, IRequest<Unit> 
{
    public UpdateQuestionSubmissionDto QuestionSubmission { get; set; }
}