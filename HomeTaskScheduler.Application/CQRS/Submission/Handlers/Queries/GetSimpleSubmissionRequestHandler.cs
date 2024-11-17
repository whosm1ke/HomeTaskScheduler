using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Submission.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Submissions;

namespace HomeTaskScheduler.Application.CQRS.Submission.Handlers.Queries;

public class GetSimpleSubmissionRequestHandler : IRequestHandler<GetSimpleSubmissionRequest, SimpleSubmissionDto>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetSimpleSubmissionRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<SimpleSubmissionDto> Handle(GetSimpleSubmissionRequest request, CancellationToken cancellationToken)
    {
        var submission = await unitOfWork.SubmissionRepository.GetSimpleSubmissionByIdAsync(request.Id);
        return mapper.Map<SimpleSubmissionDto>(submission);
    }
}