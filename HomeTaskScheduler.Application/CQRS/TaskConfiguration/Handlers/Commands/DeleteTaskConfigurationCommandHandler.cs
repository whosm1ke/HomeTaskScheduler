using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Handlers.Commands;

public class DeleteTaskConfigurationCommandHandler : IRequestHandler<DeleteTaskConfigurationCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public DeleteTaskConfigurationCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(DeleteTaskConfigurationCommand request, CancellationToken cancellationToken)
    {
        var task = await unitOfWork.TaskConfigurationRepository.GetAsyncNoTracking(request.Id);
        
        unitOfWork.TaskConfigurationRepository.Delete(task);
        
        await unitOfWork.SaveAsync();
        return Unit.Value;
    }
}
