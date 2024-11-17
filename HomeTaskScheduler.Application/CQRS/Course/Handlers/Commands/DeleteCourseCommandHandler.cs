using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Course.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Course.Handlers.Commands;

public class DeleteCourseCommandHandler : IRequestHandler<DeleteCourseCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public DeleteCourseCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async Task<Unit> Handle(DeleteCourseCommand request, CancellationToken cancellationToken)
    {
        var course = await unitOfWork.CourseRepository.GetCourseByIdAsync(request.Id);
        unitOfWork.CourseRepository.Delete(course);

        await unitOfWork.SaveAsync();
        return Unit.Value;
    }
}