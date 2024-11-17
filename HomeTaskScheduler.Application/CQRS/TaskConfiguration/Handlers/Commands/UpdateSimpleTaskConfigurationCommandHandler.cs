using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Commands;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Handlers.Commands;

public class UpdateSimpleTaskConfigurationCommandHandler : IRequestHandler<UpdateSimpleTaskConfigurationCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public UpdateSimpleTaskConfigurationCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(UpdateSimpleTaskConfigurationCommand request, CancellationToken cancellationToken)
    {
        var task = await unitOfWork.TaskConfigurationRepository.GetSimpleTaskConfigurationByIdAsync(request.SimpleTask.Id);
        mapper.Map(request.SimpleTask, task);

        unitOfWork.TaskConfigurationRepository.Update(task);

        await unitOfWork.SaveAsync();
        return Unit.Value;
    }
}