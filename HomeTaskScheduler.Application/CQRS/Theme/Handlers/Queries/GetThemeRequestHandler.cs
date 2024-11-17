using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Theme.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Feed;

namespace HomeTaskScheduler.Application.CQRS.Theme.Handlers.Queries;

public class GetThemeRequestHandler : IRequestHandler<GetThemeRequest, ThemeDto>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetThemeRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<ThemeDto> Handle(GetThemeRequest request, CancellationToken cancellationToken)
    {
        var theme = await unitOfWork.ThemeRepository.GetThemeByIdAsync(request.Id);
        

        return mapper.Map<ThemeDto>(theme);
    }
}
