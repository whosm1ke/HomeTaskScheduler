using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Submissions;

namespace HomeTaskScheduler.Application.Contracts.Persistence;

public interface ISubmissionRepository : IGenericRepository<AbstractSubmission>
{
    public QuestionSubmission GetQuestionSubmissionByIdAsync(Guid id);
    public SimpleSubmission GetSimpleSubmissionByIdAsync(Guid id);
    public TestSubmission GetTestSubmissionByIdAsync(Guid id);
}