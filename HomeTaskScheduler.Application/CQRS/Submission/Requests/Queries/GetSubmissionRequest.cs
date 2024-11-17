using HomeTaskScheduler.Application.DTO.Submissions;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Submission.Requests.Queries;

    public class GetTestSubmissionRequest : UserRequest, IRequest<TestSubmissionDto>
    {
        public Guid Id { get; set; }
    }

    public class GetQuestionSubmissionRequest : UserRequest, IRequest<QuestionSubmissionDto>
    {
        public Guid Id { get; set; }
    }

    public class GetSimpleSubmissionRequest : UserRequest, IRequest<SimpleSubmissionDto>
    {
        public Guid Id { get; set; }
    }
