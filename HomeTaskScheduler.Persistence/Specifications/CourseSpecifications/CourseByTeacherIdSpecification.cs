using HomeTaskScheduler.Domain.Entities.Feed;
using HomeTaskScheduler.Persistence.Specifications.BaseLogic;

namespace HomeTaskScheduler.Persistence.Specifications.CourseSpecifications;

public class CourseByTeacherIdSpecification : Specification<Course>
{
    public CourseByTeacherIdSpecification(Guid teacherId) : base(course => course.Teachers.Any(t => t.Id == teacherId))
    {
    }
}