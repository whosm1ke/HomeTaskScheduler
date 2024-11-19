using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Persistence.Specifications.BaseLogic;

namespace HomeTaskScheduler.Persistence.Specifications.SubmissionSpecifications;

public class SubmissionByIdSpecification : Specification<AbstractSubmission> 
{
    public SubmissionByIdSpecification(Guid id) : base(sub => sub.Id == id)
    {
        AddInclude(x => x.Attachments);
    }
}