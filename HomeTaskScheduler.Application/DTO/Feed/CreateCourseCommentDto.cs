using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Feed;

public class CreateCourseCommentDto 
{
    public string CommentPayload { get; set; }
    public CommentTargetType CommentTargetType
    {
        get => CommentTargetType.Course;
    }
    public Guid CourseId { get; set; }
}