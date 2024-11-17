using HomeTaskScheduler.Application.DTO.Common;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Submission.Requests.Queries;

    public class GetAllSubmissionRequest : UserRequest, IRequest<IReadOnlyList<AbstractSubmissionDto>>;
