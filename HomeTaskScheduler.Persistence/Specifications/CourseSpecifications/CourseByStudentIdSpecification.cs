using HomeTaskScheduler.Domain.Entities.Feed;
using HomeTaskScheduler.Persistence.Specifications.BaseLogic;

namespace HomeTaskScheduler.Persistence.Specifications.CourseSpecifications;

public class CourseByStudentIdSpecification : Specification<Course>
{
    public CourseByStudentIdSpecification(Guid studentId) : base(course => course.Students.Any(st => st.Id == studentId))
    {
    }
}