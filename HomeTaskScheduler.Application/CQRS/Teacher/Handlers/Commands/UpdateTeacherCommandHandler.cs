using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Teacher.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Teacher.Handlers.Commands;

public class UpdateTeacherCommandHandler : IRequestHandler<UpdateTeacherCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public UpdateTeacherCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateTeacherCommand request, CancellationToken cancellationToken)
    {
        var teacher = await unitOfWork.UserRepository.GetTeacherByIdAsync(request.Teacher.Id);
        mapper.Map(request.Teacher, teacher);

        unitOfWork.UserRepository.Update(teacher);

        await unitOfWork.SaveAsync();
        return Unit.Value;
    }
}