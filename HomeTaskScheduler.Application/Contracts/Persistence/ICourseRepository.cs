using HomeTaskScheduler.Domain.Entities.Feed;

namespace HomeTaskScheduler.Application.Contracts.Persistence;

public interface ICourseRepository : IGenericRepository<Course>
{
    public Course GetCourseByIdAsync(Guid id);
}