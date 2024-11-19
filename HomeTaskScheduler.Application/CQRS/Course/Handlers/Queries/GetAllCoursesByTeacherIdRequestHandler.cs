using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Course.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Feed;

namespace HomeTaskScheduler.Application.CQRS.Course.Handlers.Queries;

public class GetAllCoursesByTeacherIdRequestHandler : IRequestHandler<GetAllCoursesByTeacherIdRequest, IReadOnlyList<CourseListDto>>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetAllCoursesByTeacherIdRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<IReadOnlyList<CourseListDto>> Handle(GetAllCoursesByTeacherIdRequest request, CancellationToken cancellationToken)
    {
        var courses = await unitOfWork.CourseRepository.GetAllByTeacherIdAsync(request.TeacherId);
        
        return mapper.Map<List<CourseListDto>>(courses);
    }
}