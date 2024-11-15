using HomeTaskScheduler.Application.DTO.Common;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Feed;

public class CommentDto : IEntity
{
    public Guid Id { get; set; }
    public string CommentPayload { get; set; }
    public CommentTargetType CommentTargetType { get; set; }
    public Guid? AbstractTaskId { get; set; }
    public Guid? CourseId { get; set; }
    public Guid AbstractUserId { get; set; }
}