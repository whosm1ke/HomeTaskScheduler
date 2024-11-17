using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Tasks;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Handlers.Queries;

public class
    GetTestTaskConfigurationRequestHandler : IRequestHandler<GetTestTaskConfigurationRequest, TestTaskConfigurationDto>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetTestTaskConfigurationRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async Task<TestTaskConfigurationDto> Handle(GetTestTaskConfigurationRequest request,
        CancellationToken cancellationToken)
    {
        var task = await unitOfWork.TaskConfigurationRepository.GetTestTaskConfigurationByIdAsync(request.Id);
        return mapper.Map<TestTaskConfigurationDto>(task);
    }
}