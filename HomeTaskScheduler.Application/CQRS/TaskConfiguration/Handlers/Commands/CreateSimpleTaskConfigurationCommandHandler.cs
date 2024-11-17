using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Commands;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Handlers.Commands;

public class CreateSimpleTaskConfigurationCommandHandler : IRequestHandler<CreateSimpleTaskConfigurationCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public CreateSimpleTaskConfigurationCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(CreateSimpleTaskConfigurationCommand request, CancellationToken cancellationToken)
    {
        var task = mapper.Map<Domain.Entities.Tasks.SimpleTaskConfiguration>(request.SimpleTask);

        await unitOfWork.TaskConfigurationRepository.AddAsync(task);

        await unitOfWork.SaveAsync();
        
        return Unit.Value;
    }
}