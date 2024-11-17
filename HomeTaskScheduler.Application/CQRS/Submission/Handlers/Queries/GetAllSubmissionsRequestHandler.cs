using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Submission.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Common;

namespace HomeTaskScheduler.Application.CQRS.Submission.Handlers.Queries;

public class
    GetAllSubmissionRequestHandler : IRequestHandler<GetAllSubmissionRequest, IReadOnlyList<AbstractSubmissionDto>>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetAllSubmissionRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<IReadOnlyList<AbstractSubmissionDto>> Handle(GetAllSubmissionRequest request, CancellationToken cancellationToken)
    {
        var submissions = await unitOfWork.SubmissionRepository.GetAllAsync();

        return mapper.Map<List<AbstractSubmissionDto>>(submissions);
    }
}