using HomeTaskScheduler.Application.DTO.Feed;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Theme.Requests.Queries;

public class GetThemeRequest : UserRequest, IRequest<ThemeDto>
{
    public Guid Id { get; set; }
}