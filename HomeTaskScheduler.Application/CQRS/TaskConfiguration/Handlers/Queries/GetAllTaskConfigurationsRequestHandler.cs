using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Tasks;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Handlers.Queries;

public class GetAllTaskConfigurationsRequestHandler : IRequestHandler<GetAllTaskConfigurationsRequest, IReadOnlyList<TaskConfigurationListDto>>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetAllTaskConfigurationsRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<IReadOnlyList<TaskConfigurationListDto>> Handle(GetAllTaskConfigurationsRequest request, CancellationToken cancellationToken)
    {
        var tasks = await unitOfWork.TaskConfigurationRepository.GetAllAsync(request.CourseId);
        return mapper.Map<List<TaskConfigurationListDto>>(tasks);
    }
}
