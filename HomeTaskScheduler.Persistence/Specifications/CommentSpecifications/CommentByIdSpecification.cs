using HomeTaskScheduler.Domain.Entities.Feed;
using HomeTaskScheduler.Persistence.Specifications.BaseLogic;

namespace HomeTaskScheduler.Persistence.Specifications.CommentSpecifications;

public class CommentByIdSpecification : Specification<Comment>
{
    public CommentByIdSpecification(Guid id) : base(comm => comm.Id == id)
    {
        
    }
}