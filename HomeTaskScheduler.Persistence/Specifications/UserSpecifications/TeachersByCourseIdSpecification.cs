using HomeTaskScheduler.Domain.Entities.Users;
using HomeTaskScheduler.Persistence.Specifications.BaseLogic;

namespace HomeTaskScheduler.Persistence.Specifications.UserSpecifications;

public class TeachersByCourseIdSpecification : Specification<Teacher>
{
    public TeachersByCourseIdSpecification(Guid courseId) : base(teacher => teacher.Courses.Any(c => c.Id == courseId))
    {
    }
}