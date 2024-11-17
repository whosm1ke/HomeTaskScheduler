using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Submission.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Submission.Handlers.Commands;

public class CreateTestSubmissionCommandHandler : IRequestHandler<CreateTestSubmissionCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public CreateTestSubmissionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(CreateTestSubmissionCommand request, CancellationToken cancellationToken)
    {
        var submission = mapper.Map<Domain.Entities.Submissions.TestSubmission>(request.TestSubmission);

        await unitOfWork.SubmissionRepository.AddAsync(submission);

        await unitOfWork.SaveAsync();
        
        return Unit.Value;
    }
}