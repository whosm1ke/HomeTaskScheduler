using HomeTaskScheduler.Application.DTO.Tasks;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Queries;

    public class GetAllTaskConfigurationRequest : UserRequest, IRequest<IReadOnlyList<TaskConfigurationListDto>>;
