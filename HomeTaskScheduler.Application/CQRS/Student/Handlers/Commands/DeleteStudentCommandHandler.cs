using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Student.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Student.Handlers.Commands;

public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public DeleteStudentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
    {
        var student = await unitOfWork.UserRepository.GetAsyncNoTracking(request.Id);
        
        unitOfWork.UserRepository.Delete(student);
        
        await unitOfWork.SaveAsync();
        return Unit.Value;
    }
}
