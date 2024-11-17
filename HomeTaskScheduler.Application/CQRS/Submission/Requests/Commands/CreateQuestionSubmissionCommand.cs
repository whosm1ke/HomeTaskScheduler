using HomeTaskScheduler.Application.DTO.Submissions;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Submission.Requests.Commands;

public class CreateQuestionSubmissionCommand : UserRequest, IRequest<Unit>
{
    public CreateQuestionSubmissionDto QuestionSubmission { get; set; }
}