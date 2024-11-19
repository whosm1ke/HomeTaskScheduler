using HomeTaskScheduler.Domain.Entities.Users;
using HomeTaskScheduler.Persistence.Specifications.BaseLogic;

namespace HomeTaskScheduler.Persistence.Specifications.UserSpecifications;

public class StudentByIdSpecification : Specification<Student>
{
    public StudentByIdSpecification(Guid studentId) : base(student => student.Id == studentId)
    {
        AddInclude(student => student.Courses);
        AddInclude(student => student.Tasks);
        AddInclude(student => student.Submissions);
        AddInclude(student => student.Comments);
    }
}