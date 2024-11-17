using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Submission.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Submission.Handlers.Commands;

public class UpdateTestSubmissionCommandHandler : IRequestHandler<UpdateTestSubmissionCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public UpdateTestSubmissionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(UpdateTestSubmissionCommand request, CancellationToken cancellationToken)
    {
        var submission = await unitOfWork.SubmissionRepository.GetTestSubmissionByIdAsync(request.TestSubmission.Id);
        mapper.Map(request.TestSubmission, submission);

        unitOfWork.SubmissionRepository.Update(submission);

        await unitOfWork.SaveAsync();
        return Unit.Value;
    }
}