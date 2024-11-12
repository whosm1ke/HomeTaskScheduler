using HomeTaskScheduler.Domain.Common;
namespace HomeTaskScheduler.Application.Contracts.Persistence;

public interface IGenericRepository<T> where T : class, IEntity
{
    public IQueryable<T> TrackedQueryable { get; }
    public IQueryable<T> Queryable { get; }
    Task<T?> GetAsync(Guid id);
    Task<T?> GetAsyncNoTracking(Guid id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<IReadOnlyList<T>> GetAllAsyncNoTracking();
    Task<T> AddAsync(T item);
    Task<bool> ExistsAsync(Guid id);
    void Update(T item);
    void UpdateRange(IEnumerable<T> items);
    void Delete(T item);
    void DeleteRange(IEnumerable<T> items);
}