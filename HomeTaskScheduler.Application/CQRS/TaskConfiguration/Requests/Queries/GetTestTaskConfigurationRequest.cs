using HomeTaskScheduler.Application.DTO.Tasks;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Queries;

public class GetTestTaskConfigurationRequest : UserRequest, IRequest<TestTaskConfigurationDto>
{
    public Guid Id { get; set; }
}