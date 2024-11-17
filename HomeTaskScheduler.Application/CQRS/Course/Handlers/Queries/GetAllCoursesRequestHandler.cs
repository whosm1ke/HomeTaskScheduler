using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Course.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Feed;

namespace HomeTaskScheduler.Application.CQRS.Course.Handlers.Queries;

public class GetAllCourseRequestHandler : IRequestHandler<GetAllCourseRequest, IReadOnlyList<CourseListDto>>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetAllCourseRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<IReadOnlyList<CourseListDto>> Handle(GetAllCourseRequest request, CancellationToken cancellationToken)
    {
        var courses = await unitOfWork.CourseRepository.GetAllAsync();
        
        return mapper.Map<List<CourseListDto>>(courses);
    }
}
