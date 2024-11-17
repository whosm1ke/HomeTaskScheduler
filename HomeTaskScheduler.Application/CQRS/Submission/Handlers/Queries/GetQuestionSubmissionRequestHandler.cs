using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.CQRS.Submission.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Submissions;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Submission.Handlers.Queries;

public class GetQuestionSubmissionRequestHandler : IRequestHandler<GetQuestionSubmissionRequest, QuestionSubmissionDto>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetQuestionSubmissionRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<QuestionSubmissionDto> Handle(GetQuestionSubmissionRequest request, CancellationToken cancellationToken)
    {
        var submission = await unitOfWork.SubmissionRepository.GetQuestionSubmissionByIdAsync(request.Id);
        return mapper.Map<QuestionSubmissionDto>(submission);
    }
}