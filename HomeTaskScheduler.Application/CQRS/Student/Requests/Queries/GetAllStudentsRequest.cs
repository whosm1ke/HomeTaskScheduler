using HomeTaskScheduler.Application.DTO.Users;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Student.Requests.Queries;

    public class GetAllStudentRequest : UserRequest, IRequest<IReadOnlyList<UserListDto>>;
