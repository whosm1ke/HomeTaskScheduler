using HomeTaskScheduler.Domain.Entities.Users;
using HomeTaskScheduler.Persistence.Specifications.BaseLogic;

namespace HomeTaskScheduler.Persistence.Specifications.UserSpecifications;

public class TeacherByIdSpecification : Specification<Teacher>
{
    public TeacherByIdSpecification(Guid teacherId) : base(teacher => teacher.Id == teacherId)
    {
        AddInclude(teacher => teacher.Courses);
        AddInclude(teacher => teacher.Comments);
    }
}