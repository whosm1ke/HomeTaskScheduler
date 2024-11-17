using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Theme.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Theme.Handlers.Commands;

public class DeleteThemeCommandHandler : IRequestHandler<DeleteThemeCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public DeleteThemeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(DeleteThemeCommand request, CancellationToken cancellationToken)
    {
        var theme = await unitOfWork.ThemeRepository.GetThemeByIdAsync(request.Id);
        
        unitOfWork.ThemeRepository.Delete(theme);
        
        await unitOfWork.SaveAsync();
        
        return Unit.Value;
    }
}
