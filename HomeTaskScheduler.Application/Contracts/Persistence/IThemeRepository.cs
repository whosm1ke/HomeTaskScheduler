using HomeTaskScheduler.Domain.Entities.Feed;

namespace HomeTaskScheduler.Application.Contracts.Persistence;

public interface IThemeRepository : IGenericRepository<Theme>
{
    public Task<Theme?> GetThemeByIdAsync(Guid id);
}