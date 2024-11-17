using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Theme.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Theme.Handlers.Commands;

public class UpdateThemeCommandHandler : IRequestHandler<UpdateThemeCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public UpdateThemeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateThemeCommand request, CancellationToken cancellationToken)
    {
        var theme = await unitOfWork.ThemeRepository.GetThemeByIdAsync(request.Theme.Id);
        mapper.Map(request.Theme, theme);

        unitOfWork.ThemeRepository.Update(theme);
        
        await unitOfWork.SaveAsync();
        
        return Unit.Value;
    }
}