using HomeTaskScheduler.Domain.Entities.Users;
using HomeTaskScheduler.Persistence.Specifications.BaseLogic;

namespace HomeTaskScheduler.Persistence.Specifications.UserSpecifications;

public class StudentByIdWithCoursesSpecification : Specification<Student>
{
    public StudentByIdWithCoursesSpecification(Guid userId) : base(student => student.Id == userId)
    {
        AddInclude(student => student.Courses);
    }
}

