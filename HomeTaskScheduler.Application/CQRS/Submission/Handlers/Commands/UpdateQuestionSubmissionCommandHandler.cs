using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.CQRS.Submission.Requests.Commands;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Submission.Handlers.Commands;

public class UpdateQuestionSubmissionCommandHandler : IRequestHandler<UpdateQuestionSubmissionCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public UpdateQuestionSubmissionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(UpdateQuestionSubmissionCommand request, CancellationToken cancellationToken)
    {
        var submission = await unitOfWork.SubmissionRepository.GetQuestionSubmissionByIdAsync(request.QuestionSubmission.Id);
        mapper.Map(request.QuestionSubmission, submission);

        unitOfWork.SubmissionRepository.Update(submission);

        await unitOfWork.SaveAsync();
        return Unit.Value;
    }
}