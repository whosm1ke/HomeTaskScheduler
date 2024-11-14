using HomeTaskScheduler.Application.DTO.Common;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Feed;

public class CreateCommentDto : ICommonCommentDto
{
    public string CommentPayload { get; set; }
    public CommentTargetType CommentTargetType { get; set; }
    /// <summary>
    /// TargetId -> TaskConfigurationId or CourseId, depends on CommentTargetType
    /// </summary>
    public Guid TargetId { get; set; }
    public Guid UserId { get; set; }
}