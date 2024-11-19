using HomeTaskScheduler.Application.DTO.Feed;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Theme.Requests.Queries;

public class GetAllThemesRequest : UserRequest, IRequest<IReadOnlyList<ThemeDto>>
{
    public Guid CourseId { get; set; }
}