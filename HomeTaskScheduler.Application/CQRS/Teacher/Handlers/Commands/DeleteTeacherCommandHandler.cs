using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Teacher.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Teacher.Handlers.Commands;

public class DeleteTeacherCommandHandler : IRequestHandler<DeleteTeacherCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public DeleteTeacherCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(DeleteTeacherCommand request, CancellationToken cancellationToken)
    {
        var teacher = await unitOfWork.UserRepository.GetAsyncNoTracking(request.Id);
        
        unitOfWork.UserRepository.Delete(teacher);
        
        await unitOfWork.SaveAsync();
        return Unit.Value;
    }
}
