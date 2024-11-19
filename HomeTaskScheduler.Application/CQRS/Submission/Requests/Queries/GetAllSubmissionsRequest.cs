using HomeTaskScheduler.Application.DTO.Common;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Submission.Requests.Queries;

public class GetAllSubmissionsRequest : UserRequest, IRequest<IReadOnlyList<AbstractSubmissionDto>>
{
    public Guid CourseId { get; set; }
}
