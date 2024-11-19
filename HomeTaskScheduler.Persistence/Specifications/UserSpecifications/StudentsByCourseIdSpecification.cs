using HomeTaskScheduler.Domain.Entities.Users;
using HomeTaskScheduler.Persistence.Specifications.BaseLogic;

namespace HomeTaskScheduler.Persistence.Specifications.UserSpecifications;

public class StudentsByCourseIdSpecification : Specification<Student>
{
    public StudentsByCourseIdSpecification(Guid courseId) : base(student => student.Courses.Any(c => c.Id == courseId))
    {
    }
}