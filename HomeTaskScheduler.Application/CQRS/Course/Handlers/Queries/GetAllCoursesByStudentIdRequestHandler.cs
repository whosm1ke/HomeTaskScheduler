using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Application.CQRS.Course.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Feed;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Course.Handlers.Queries;

public class GetAllCoursesByStudentIdRequestHandler : IRequestHandler<GetAllCoursesByStudentIdRequest, IReadOnlyList<CourseListDto>>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetAllCoursesByStudentIdRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }
    public async Task<IReadOnlyList<CourseListDto>> Handle(GetAllCoursesByStudentIdRequest request, CancellationToken cancellationToken)
    {
        var courses = await unitOfWork.CourseRepository.GetAllByStudentIdAsync(request.StudentId);
        
        return mapper.Map<List<CourseListDto>>(courses);
    }
}