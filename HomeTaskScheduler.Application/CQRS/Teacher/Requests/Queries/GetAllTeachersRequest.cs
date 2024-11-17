using HomeTaskScheduler.Application.DTO.Users;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Teacher.Requests.Queries;

    public class GetAllTeacherRequest : UserRequest, IRequest<IReadOnlyList<UserListDto>>;
