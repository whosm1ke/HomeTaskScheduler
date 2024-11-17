using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.CQRS.Submission.Requests.Commands;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Submission.Handlers.Commands;

public class UpdateSimpleSubmissionCommandHandler : IRequestHandler<UpdateSimpleSubmissionCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public UpdateSimpleSubmissionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(UpdateSimpleSubmissionCommand request, CancellationToken cancellationToken)
    {
        var submission = await unitOfWork.SubmissionRepository.GetSimpleSubmissionByIdAsync(request.SimpleSubmission.Id);
        mapper.Map(request.SimpleSubmission, submission);

        unitOfWork.SubmissionRepository.Update(submission);

        await unitOfWork.SaveAsync();
        return Unit.Value;
    }
}