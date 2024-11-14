using HomeTaskScheduler.Application.DTO.Common;

namespace HomeTaskScheduler.Application.DTO.Feed;

public class CourseDto : IEntity
{
    public Guid Id { get; set; }
    public string CourseName { get; set; }
    public string CourseDescription { get; set; }
    public ICollection<Guid> TeacherIds { get; set; }
    public ICollection<Guid> StudentIds { get; set; }
    public ICollection<Guid> TaskIds { get; set; }
}