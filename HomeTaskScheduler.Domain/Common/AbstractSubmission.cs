using HomeTaskScheduler.Domain.Entities.Users;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Domain.Common;

public abstract class AbstractSubmission : IAuditableEntity
{
    public AbstractSubmission()
    {
        Attachments = new HashSet<AbstractAttachment>();
    }

    public ICollection<AbstractAttachment> Attachments { get; set; }
    public uint? Grade { get; set; }
    public Guid TaskConfigurationId { get; set; }
    public virtual AbstractTaskConfiguration Task { get; set; }
    public SubmissionStatus SubmissionStatus { get; set; }
    public SubmissionType SubmissionType { get; protected set; }
    public virtual Student Student { get; set; }
    public Guid StudentId { get; set; }
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
}