using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Domain.Entities.Feed;

public class Comment : IAuditableEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public string CommentPayload { get; set; }
    public CommentTargetType CommentTargetType { get; set; }
    public Guid? AbstractTaskId { get; set; }
    public Guid? CourseId { get; set; }
}