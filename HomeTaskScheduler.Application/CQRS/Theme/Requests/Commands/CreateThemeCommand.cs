using HomeTaskScheduler.Application.DTO.Feed;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Theme.Requests.Commands;

public class CreateThemeCommand : UserRequest, IRequest<Unit>
{
    public CreateThemeDto Theme { get; set; }
}
