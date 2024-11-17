using AutoMapper;
using HomeTaskScheduler.Application.Contracts.Persistence;
using MediatR;
using HomeTaskScheduler.Application.CQRS.Teacher.Requests.Queries;
using HomeTaskScheduler.Application.DTO.Users;

namespace HomeTaskScheduler.Application.CQRS.Teacher.Handlers.Queries;

public class GetTeacherRequestHandler : IRequestHandler<GetTeacherRequest, TeacherDto>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public GetTeacherRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    public async Task<TeacherDto> Handle(GetTeacherRequest request, CancellationToken cancellationToken)
    {
        var teacher = await unitOfWork.UserRepository.GetTeacherByIdAsync(request.Id);


        return mapper.Map<TeacherDto>(teacher);
    }
}