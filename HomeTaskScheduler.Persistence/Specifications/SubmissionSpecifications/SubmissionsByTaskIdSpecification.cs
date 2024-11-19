using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Persistence.Specifications.BaseLogic;

namespace HomeTaskScheduler.Persistence.Specifications.SubmissionSpecifications;

public class SubmissionsByTaskIdSpecification : Specification<AbstractSubmission> 
{
    public SubmissionsByTaskIdSpecification(Guid taskId) : base(sub => sub.TaskConfigurationId == taskId)
    {
        AddInclude(x => x.Attachments);
    }
}