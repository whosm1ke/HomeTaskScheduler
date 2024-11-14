using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Feed;

public class CreateTaskCommentDto 
{
    public string CommentPayload { get; set; }
    public CommentTargetType CommentTargetType
    {
        get => CommentTargetType.Task;
    }
    public Guid AbstractTaskId { get; set; }
    public Guid UserId { get; set; }
}