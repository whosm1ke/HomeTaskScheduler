using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Teacher.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Teacher.Handlers.Commands;

public class CreateTeacherCommandHandler : IRequestHandler<CreateTeacherCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public CreateTeacherCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(CreateTeacherCommand request, CancellationToken cancellationToken)
    {
        var teacher = mapper.Map<Domain.Entities.Users.Teacher>(request.Teacher);

        await unitOfWork.UserRepository.AddAsync(teacher);

        await unitOfWork.SaveAsync();
        
        return Unit.Value;
    }
}
