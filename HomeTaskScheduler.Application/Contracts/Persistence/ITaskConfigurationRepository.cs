using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Tasks;

namespace HomeTaskScheduler.Application.Contracts.Persistence;

public interface ITaskConfigurationRepository : IGenericRepository<AbstractTaskConfiguration>
{
    public QuestionTaskConfiguration GetQuestionTaskConfigurationByIdAsync(Guid id);
    public SimpleTaskConfiguration GetSimpleTaskConfigurationByIdAsync(Guid id);
    public TestTaskConfiguration GetTestTaskConfigurationByIdAsync(Guid id);
}