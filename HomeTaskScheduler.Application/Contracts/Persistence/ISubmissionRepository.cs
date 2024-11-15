using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Submissions;

namespace HomeTaskScheduler.Application.Contracts.Persistence;

public interface ISubmissionRepository : IGenericRepository<AbstractSubmission>
{
    public Task<QuestionSubmission?> GetQuestionSubmissionByIdAsync(Guid id);
    public Task<SimpleSubmission?> GetSimpleSubmissionByIdAsync(Guid id);
    public Task<TestSubmission?> GetTestSubmissionByIdAsync(Guid id);
}