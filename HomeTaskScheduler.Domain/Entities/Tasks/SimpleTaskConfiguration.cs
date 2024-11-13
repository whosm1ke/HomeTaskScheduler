using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Domain.Entities.Tasks;

public class SimpleTaskConfiguration : AbstractTaskConfiguration
{
    public SimpleTaskConfiguration()
    {
        TaskType = TaskType.SimpleTask;
    }
}

