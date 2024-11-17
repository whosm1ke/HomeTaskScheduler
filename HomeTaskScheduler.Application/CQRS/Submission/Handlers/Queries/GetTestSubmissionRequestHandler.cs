using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.CQRS.Submission.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Submissions;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Submission.Handlers.Queries;

public class GetTestSubmissionRequestHandler : IRequestHandler<GetTestSubmissionRequest, TestSubmissionDto>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetTestSubmissionRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<TestSubmissionDto> Handle(GetTestSubmissionRequest request, CancellationToken cancellationToken)
    {
        var submission = await unitOfWork.SubmissionRepository.GetTestSubmissionByIdAsync(request.Id);
        return mapper.Map<TestSubmissionDto>(submission);
    }
}