using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Commands;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Handlers.Commands;

public class CreateQuestionTaskConfigurationCommandHandler : IRequestHandler<CreateQuestionTaskConfigurationCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public CreateQuestionTaskConfigurationCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(CreateQuestionTaskConfigurationCommand request, CancellationToken cancellationToken)
    {
        var task = mapper.Map<Domain.Entities.Tasks.QuestionTaskConfiguration>(request.QuestionTask);

        await unitOfWork.TaskConfigurationRepository.AddAsync(task);

        await unitOfWork.SaveAsync();
        
        return Unit.Value;
    }
}