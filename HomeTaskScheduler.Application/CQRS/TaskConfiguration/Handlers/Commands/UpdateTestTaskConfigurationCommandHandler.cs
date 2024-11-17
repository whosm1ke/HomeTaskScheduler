using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Handlers.Commands;

public class UpdateTestTaskConfigurationCommandHandler : IRequestHandler<UpdateTestTaskConfigurationCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public UpdateTestTaskConfigurationCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(UpdateTestTaskConfigurationCommand request, CancellationToken cancellationToken)
    {
        var task = await unitOfWork.TaskConfigurationRepository.GetTestTaskConfigurationByIdAsync(request.TestTask.Id);
        mapper.Map(request.TestTask, task);

        unitOfWork.TaskConfigurationRepository.Update(task);

        await unitOfWork.SaveAsync();
        return Unit.Value;
    }
}