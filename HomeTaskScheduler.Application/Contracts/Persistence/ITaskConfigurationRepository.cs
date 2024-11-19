using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Tasks;

namespace HomeTaskScheduler.Application.Contracts.Persistence;

public interface ITaskConfigurationRepository : IGenericRepository<AbstractTaskConfiguration>
{
    public Task<QuestionTaskConfiguration?> GetQuestionTaskConfigurationByIdAsync(Guid id);
    public Task<SimpleTaskConfiguration?> GetSimpleTaskConfigurationByIdAsync(Guid id);
    public Task<TestTaskConfiguration?> GetTestTaskConfigurationByIdAsync(Guid id);
    Task<IReadOnlyList<AbstractTaskConfiguration>> GetAllAsync(Guid courseId);
}