using HomeTaskScheduler.Application.DTO.Tasks;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Queries;

public class GetSimpleTaskConfigurationRequest : UserRequest, IRequest<SimpleTaskConfigurationDto>
{
    public Guid Id { get; set; }
}