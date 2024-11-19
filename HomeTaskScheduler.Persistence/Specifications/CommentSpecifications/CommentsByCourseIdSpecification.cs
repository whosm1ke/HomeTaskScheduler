using HomeTaskScheduler.Domain.Entities.Feed;
using HomeTaskScheduler.Persistence.Specifications.BaseLogic;

namespace HomeTaskScheduler.Persistence.Specifications.CommentSpecifications;

public class CommentsByCourseIdSpecification : Specification<Comment>
{
    public CommentsByCourseIdSpecification(Guid courseId) : base(comm => comm.Course != null && comm.Course.Id == courseId)
    {
        
    }
}