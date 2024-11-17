using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Commands;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Handlers.Commands;

public class UpdateQuestionTaskConfigurationCommandHandler : IRequestHandler<UpdateQuestionTaskConfigurationCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public UpdateQuestionTaskConfigurationCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(UpdateQuestionTaskConfigurationCommand request, CancellationToken cancellationToken)
    {
        var task = await unitOfWork.TaskConfigurationRepository.GetQuestionTaskConfigurationByIdAsync(request.QuestionTask.Id);
        mapper.Map(request.QuestionTask, task);

        unitOfWork.TaskConfigurationRepository.Update(task);

        await unitOfWork.SaveAsync();
        return Unit.Value;
    }
}