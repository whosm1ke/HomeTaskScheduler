using HomeTaskScheduler.Domain.Entities.Feed;
using HomeTaskScheduler.Persistence.Specifications.BaseLogic;

namespace HomeTaskScheduler.Persistence.Specifications.CourseSpecifications;

public class CourseByIdSpecification : Specification<Course>
{
    public CourseByIdSpecification(Guid courseId) : base(course => course.Id == courseId)
    {
        AddInclude(x => x.Teachers);
        AddInclude(x => x.Comments);
        AddInclude(x => x.Students);
    }
}