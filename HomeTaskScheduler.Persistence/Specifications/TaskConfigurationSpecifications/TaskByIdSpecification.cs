using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Persistence.Specifications.BaseLogic;

namespace HomeTaskScheduler.Persistence.Specifications.TaskConfigurationSpecifications;

public class TaskByIdSpecification : Specification<AbstractTaskConfiguration>
{
    public TaskByIdSpecification(Guid id) : base(task => task.Id == id)
    {
        AddInclude(x => x.Submissions);
        AddInclude(x => x.Attachments);
        AddInclude(x => x.Comments);
        AddInclude(x => x.Courses);
        AddInclude(x => x.Students);
    }
}