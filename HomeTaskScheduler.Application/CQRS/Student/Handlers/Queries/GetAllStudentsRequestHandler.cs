using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Student.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Users;

namespace HomeTaskScheduler.Application.CQRS.Student.Handlers.Queries;

public class GetAllStudentsRequestHandler : IRequestHandler<GetAllStudentsRequest, IReadOnlyList<UserListDto>>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetAllStudentsRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async Task<IReadOnlyList<UserListDto>> Handle(GetAllStudentsRequest request, CancellationToken cancellationToken)
    {
        var students = await unitOfWork.UserRepository.GetAllStudentsAsync(request.CourseId);


        return mapper.Map<List<UserListDto>>(students);
    }
}
