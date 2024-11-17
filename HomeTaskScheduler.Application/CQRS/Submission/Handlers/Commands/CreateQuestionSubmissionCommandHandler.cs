using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.CQRS.Submission.Requests.Commands;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Submission.Handlers.Commands;

public class CreateQuestionSubmissionCommandHandler : IRequestHandler<CreateQuestionSubmissionCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public CreateQuestionSubmissionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(CreateQuestionSubmissionCommand request, CancellationToken cancellationToken)
    {
        var submission = mapper.Map<Domain.Entities.Submissions.QuestionSubmission>(request.QuestionSubmission);

        await unitOfWork.SubmissionRepository.AddAsync(submission);

        await unitOfWork.SaveAsync();
        
        return Unit.Value;
    }
}