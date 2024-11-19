using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Persistence.Specifications.BaseLogic;

namespace HomeTaskScheduler.Persistence.Specifications.AttachmentSpecifications;

public class AttachmentByIdSpecification : Specification<AbstractAttachment>
{
    public AttachmentByIdSpecification(Guid id): base(attachment => attachment.Id == id)
    {
    }
}