using HomeTaskScheduler.Application.DTO.Users;
using MediatR;

namespace HomeTaskScheduler.Application.CQRS.Student.Requests.Queries;

    public class GetStudentRequest : UserRequest, IRequest<StudentDto>
    {
        public Guid Id { get; set; }
    }
