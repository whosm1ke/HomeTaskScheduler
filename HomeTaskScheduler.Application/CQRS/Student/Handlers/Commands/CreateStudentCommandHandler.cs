using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Student.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Student.Handlers.Commands;

public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public CreateStudentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
    {
        var student = mapper.Map<Domain.Entities.Users.Student>(request.Student);

        await unitOfWork.UserRepository.AddAsync(student);
        
        return Unit.Value;
    }
}
