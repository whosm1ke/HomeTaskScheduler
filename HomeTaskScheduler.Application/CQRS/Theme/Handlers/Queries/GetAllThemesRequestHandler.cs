using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Theme.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Feed;

namespace HomeTaskScheduler.Application.CQRS.Theme.Handlers.Queries;

public class GetAllThemeRequestHandler : IRequestHandler<GetAllThemesRequest, IReadOnlyList<ThemeDto>>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetAllThemeRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async Task<IReadOnlyList<ThemeDto>> Handle(GetAllThemesRequest request, CancellationToken cancellationToken)
    {
        var themes = await unitOfWork.ThemeRepository.GetAllAsync(request.CourseId);

        return mapper.Map<List<ThemeDto>>(themes);
    }
}
