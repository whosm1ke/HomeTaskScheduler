using HomeTaskScheduler.Domain.Entities.Feed;

namespace HomeTaskScheduler.Application.Contracts.Persistence;

public interface ICommentRepository : IGenericRepository<Comment>
{
    public Comment GetCommentByIdAsync(Guid id);
}