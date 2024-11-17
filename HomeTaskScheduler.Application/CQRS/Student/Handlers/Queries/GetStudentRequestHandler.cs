using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Student.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Users;

namespace HomeTaskScheduler.Application.CQRS.Student.Handlers.Queries;

public class GetStudentRequestHandler : IRequestHandler<GetStudentRequest, StudentDto>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetStudentRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async Task<StudentDto> Handle(GetStudentRequest request, CancellationToken cancellationToken)
    {
        var student = await unitOfWork.UserRepository.GetStudentByIdAsync(request.Id);


        return mapper.Map<StudentDto>(student);
    }
}
