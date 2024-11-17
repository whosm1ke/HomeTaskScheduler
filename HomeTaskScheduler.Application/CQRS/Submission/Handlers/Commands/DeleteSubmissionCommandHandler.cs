using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Submission.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Submission.Handlers.Commands;

public class DeleteSubmissionCommandHandler : IRequestHandler<DeleteSubmissionCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public DeleteSubmissionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(DeleteSubmissionCommand request, CancellationToken cancellationToken)
    {
        var submission = await unitOfWork.SubmissionRepository.GetAsyncNoTracking(request.Id);
        
        unitOfWork.SubmissionRepository.Delete(submission);
        
        await unitOfWork.SaveAsync();
        return Unit.Value;
    }
}
