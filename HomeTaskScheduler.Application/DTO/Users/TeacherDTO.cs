using HomeTaskScheduler.Application.DTO.Common;

namespace HomeTaskScheduler.Application.DTO.Users;

public class TeacherDto : AbstractUserDto
{
    public ICollection<Guid> Courses { get; set; }
}