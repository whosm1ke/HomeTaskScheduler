using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Course.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Feed;

namespace HomeTaskScheduler.Application.CQRS.Course.Handlers.Queries;

public class GetCourseRequestHandler : IRequestHandler<GetCourseRequest, CourseDto>
{
    
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetCourseRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<CourseDto> Handle(GetCourseRequest request, CancellationToken cancellationToken)
    {
        var course = await unitOfWork.CourseRepository.GetCourseByIdAsync(request.Id);
        
        return mapper.Map<CourseDto>(course);
    }
}
