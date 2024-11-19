using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Persistence.Specifications.BaseLogic;

namespace HomeTaskScheduler.Persistence.Specifications.TaskConfigurationSpecifications;

public class TaskByCourseIdSpecification : Specification<AbstractTaskConfiguration>
{
    public TaskByCourseIdSpecification(Guid courseId) : base(task => task.Courses.Any(c => c.Id == courseId))
    {
        AddInclude(x => x.Submissions);
        AddInclude(x => x.Attachments);
        AddInclude(x => x.Comments);
        AddInclude(x => x.Courses);
        AddInclude(x => x.Students);
    }
}