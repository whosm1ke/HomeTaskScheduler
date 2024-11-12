using HomeTaskScheduler.Domain.Entities.Feed;

namespace HomeTaskScheduler.Application.Contracts.Persistence;

public interface IThemeRepository : IGenericRepository<Theme>
{
    public Theme GetThemeByIdAsync(Guid id);
}