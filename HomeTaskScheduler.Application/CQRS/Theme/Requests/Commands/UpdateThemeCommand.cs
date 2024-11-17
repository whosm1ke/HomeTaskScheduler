using HomeTaskScheduler.Application.DTO.Feed;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Theme.Requests.Commands;

public class UpdateThemeCommand : UserRequest, IRequest<Unit>
{
    public UpdateThemeDto Theme { get; set; }
}
