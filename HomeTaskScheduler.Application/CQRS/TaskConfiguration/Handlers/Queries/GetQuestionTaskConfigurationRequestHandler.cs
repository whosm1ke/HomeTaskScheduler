using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Tasks;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Handlers.Queries;

public class
    GetQuestionTaskConfigurationRequestHandler : IRequestHandler<GetQuestionTaskConfigurationRequest, QuestionTaskConfigurationDto>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetQuestionTaskConfigurationRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async Task<QuestionTaskConfigurationDto> Handle(GetQuestionTaskConfigurationRequest request,
        CancellationToken cancellationToken)
    {
        var task = await unitOfWork.TaskConfigurationRepository.GetQuestionTaskConfigurationByIdAsync(request.Id);
        return mapper.Map<QuestionTaskConfigurationDto>(task);
    }
}