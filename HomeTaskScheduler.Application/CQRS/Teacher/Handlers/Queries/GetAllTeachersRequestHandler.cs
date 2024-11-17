using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Teacher.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Users;

namespace HomeTaskScheduler.Application.CQRS.Teacher.Handlers.Queries;

public class GetAllTeacherRequestHandler : IRequestHandler<GetAllTeacherRequest, IReadOnlyList<UserListDto>>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetAllTeacherRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async Task<IReadOnlyList<UserListDto>> Handle(GetAllTeacherRequest request, CancellationToken cancellationToken)
    {
        var teachers = await unitOfWork.UserRepository.GetAllAsync();


        return mapper.Map<List<UserListDto>>(teachers);
    }
}