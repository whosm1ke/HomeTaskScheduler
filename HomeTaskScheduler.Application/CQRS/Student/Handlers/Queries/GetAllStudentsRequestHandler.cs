using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Student.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Users;

namespace HomeTaskScheduler.Application.CQRS.Student.Handlers.Queries;

public class GetAllStudentRequestHandler : IRequestHandler<GetAllStudentRequest, IReadOnlyList<UserListDto>>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetAllStudentRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async Task<IReadOnlyList<UserListDto>> Handle(GetAllStudentRequest request, CancellationToken cancellationToken)
    {
        var students = await unitOfWork.UserRepository.GetAllAsync();


        return mapper.Map<List<UserListDto>>(students);
    }
}
