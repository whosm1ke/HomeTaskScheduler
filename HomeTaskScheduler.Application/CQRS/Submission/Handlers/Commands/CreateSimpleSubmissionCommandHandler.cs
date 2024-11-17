using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.CQRS.Submission.Requests.Commands;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Submission.Handlers.Commands;

public class CreateSimpleSubmissionCommandHandler : IRequestHandler<CreateSimpleSubmissionCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public CreateSimpleSubmissionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(CreateSimpleSubmissionCommand request, CancellationToken cancellationToken)
    {
        var submission = mapper.Map<Domain.Entities.Submissions.SimpleSubmission>(request.SimpleSubmission);

        await unitOfWork.SubmissionRepository.AddAsync(submission);

        await unitOfWork.SaveAsync();
        
        return Unit.Value;
    }
}