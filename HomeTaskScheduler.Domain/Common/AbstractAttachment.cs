using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Domain.Common;

public abstract class AbstractAttachment : IAuditableEntity
{
    public AttachmentType AttachmentType { get; }
    public string AttachmentName { get; set; }
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }

    public AbstractTaskConfiguration? TaskConfiguration { get; set; }
    public AbstractSubmission? Submission { get; set; }
    public Guid? SubmissionId { get; set; }
    public Guid? TaskConfigurationId { get; set; }
}