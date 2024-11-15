using HomeTaskScheduler.Domain.Entities.Feed;

namespace HomeTaskScheduler.Application.Contracts.Persistence;

public interface ICourseRepository : IGenericRepository<Course>
{
    public Task<Course?> GetCourseByIdAsync(Guid id);
}