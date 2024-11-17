using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Theme.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Theme.Handlers.Commands;

public class CreateThemeCommandHandler : IRequestHandler<CreateThemeCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public CreateThemeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(CreateThemeCommand request, CancellationToken cancellationToken)
    {
        var themeEntity = mapper.Map<Domain.Entities.Feed.Theme>(request.Theme);

        await unitOfWork.ThemeRepository.AddAsync(themeEntity);
        
        return Unit.Value;
    }
}
