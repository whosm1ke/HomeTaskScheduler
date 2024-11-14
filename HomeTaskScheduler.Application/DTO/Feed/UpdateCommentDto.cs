using HomeTaskScheduler.Application.DTO.Common;

namespace HomeTaskScheduler.Application.DTO.Feed;

public class UpdateCommentDto : IEntity, ICommonCommentDto
{
    public string CommentPayload { get; set; }
    public Guid Id { get; set; }
}