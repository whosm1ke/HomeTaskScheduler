using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Course.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Course.Handlers.Commands;

public class UpdateCourseCommandHandler : IRequestHandler<UpdateCourseCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public UpdateCourseCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(UpdateCourseCommand request, CancellationToken cancellationToken)
    {
        var course = await unitOfWork.CourseRepository.GetCourseByIdAsync(request.Course.Id);

        mapper.Map(request.Course, course);

        await unitOfWork.SaveAsync();
        return Unit.Value;
    }
}
