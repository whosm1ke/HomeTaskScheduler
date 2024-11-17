using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Handlers.Commands;

public class CreateTestTaskConfigurationCommandHandler : IRequestHandler<CreateTestTaskConfigurationCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public CreateTestTaskConfigurationCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(CreateTestTaskConfigurationCommand request, CancellationToken cancellationToken)
    {
        var task = mapper.Map<Domain.Entities.Tasks.TestTaskConfiguration>(request.TestTask);

        await unitOfWork.TaskConfigurationRepository.AddAsync(task);

        await unitOfWork.SaveAsync();
        
        return Unit.Value;
    }
}