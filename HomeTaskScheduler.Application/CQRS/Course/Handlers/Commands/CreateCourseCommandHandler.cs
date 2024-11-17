using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Course.Requests.Commands;

namespace HomeTaskScheduler.Application.CQRS.Course.Handlers.Commands;

public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, Unit>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public CreateCourseCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<Unit> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
    {
        var course = mapper.Map<Domain.Entities.Feed.Course>(request.Course);

        await unitOfWork.CourseRepository.AddAsync(course);

        await unitOfWork.SaveAsync();
        
        return Unit.Value;
    }
}
