using HomeTaskScheduler.Application.DTO.Tasks;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.TaskConfiguration.Requests.Queries;

public class GetQuestionTaskConfigurationRequest : UserRequest, IRequest<QuestionTaskConfigurationDto>
{
    public Guid Id { get; set; }
}