using HomeTaskScheduler.Application.DTO.Tasks;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Queries;

public class GetAllTaskConfigurationsRequest : UserRequest, IRequest<IReadOnlyList<TaskConfigurationListDto>>
{
    public Guid CourseId { get; set; }
}
