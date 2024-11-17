using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Tasks;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Handlers.Queries;

public class
    GetSimpleTaskConfigurationRequestHandler : IRequestHandler<GetSimpleTaskConfigurationRequest, SimpleTaskConfigurationDto>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetSimpleTaskConfigurationRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async Task<SimpleTaskConfigurationDto> Handle(GetSimpleTaskConfigurationRequest request,
        CancellationToken cancellationToken)
    {
        var task = await unitOfWork.TaskConfigurationRepository.GetSimpleTaskConfigurationByIdAsync(request.Id);
        return mapper.Map<SimpleTaskConfigurationDto>(task);
    }
}