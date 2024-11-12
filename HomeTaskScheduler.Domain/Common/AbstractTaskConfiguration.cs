using HomeTaskScheduler.Domain.Entities;
using HomeTaskScheduler.Domain.Entities.Feed;
using HomeTaskScheduler.Domain.Entities.Users;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Domain.Common;

public abstract class AbstractTaskConfiguration : IAuditableEntity
{
    public AbstractTaskConfiguration()
    {
        Attachments = new HashSet<AbstractAttachment>();
        Courses = new HashSet<Course>();
        Students = new HashSet<Student>();
        Submissions = new HashSet<AbstractSubmission>();
    }
    public TaskType TaskType { get; protected set; }
    public virtual string TaskTittle { get; set; }
    public virtual string TaskInstructions { get; set; }
    public virtual ICollection<AbstractAttachment> Attachments { get; set; }
    public virtual ICollection<Course> Courses { get; set; }
    public virtual ICollection<Student> Students { get; set; }
    public virtual ICollection<AbstractSubmission> Submissions { get; set; }
    public uint? MaxMark { get; set; }
    public DateTime DueDate { get; set; }
    public virtual Theme Theme { get; set; }
    public Guid? ThemeId { get; set; }
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
}