using HomeTaskScheduler.Domain.Entities.Feed;
using HomeTaskScheduler.Persistence.Specifications.BaseLogic;

namespace HomeTaskScheduler.Persistence.Specifications.CommentSpecifications;

public class CommentsByTaskIdSpecification : Specification<Comment>
{
    public CommentsByTaskIdSpecification(Guid taskId) : base(comm => comm.AbstractTaskConfiguration != null && comm.AbstractTaskConfiguration.Id == taskId)
    {
        
    }
}