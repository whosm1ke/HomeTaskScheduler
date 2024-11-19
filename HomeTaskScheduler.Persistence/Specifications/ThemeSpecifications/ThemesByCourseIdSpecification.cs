using HomeTaskScheduler.Domain.Entities.Feed;
using HomeTaskScheduler.Persistence.Specifications.BaseLogic;

namespace HomeTaskScheduler.Persistence.Specifications.ThemeSpecifications;

public class ThemesByCourseIdSpecification : Specification<Theme>
{
    public ThemesByCourseIdSpecification(Guid courseId): base(theme => theme.CourseId == courseId)
    {
        AddInclude(x => x.Tasks);
    }
}