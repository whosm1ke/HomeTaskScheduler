using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Theme.Requests.Commands;

public class DeleteThemeCommand : UserRequest, IRequest<Unit>
{
    public Guid Id { get; set; }
}
