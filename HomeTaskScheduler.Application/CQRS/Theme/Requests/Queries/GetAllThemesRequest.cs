using HomeTaskScheduler.Application.DTO.Feed;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Theme.Requests.Queries;

public class GetAllThemeRequest : UserRequest, IRequest<IReadOnlyList<ThemeDto>>;