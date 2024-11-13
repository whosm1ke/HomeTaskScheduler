using HomeTaskScheduler.Application.DTO.Feed;
using HomeTaskScheduler.Application.DTO.Users;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Common;

public abstract class AbstractTaskConfigurationDto  : IEntity
{
    public TaskType TaskType { get; protected set; }
    public string TaskTittle { get; set; }
    public string TaskInstructions { get; set; }
    public ICollection<Guid> AttachmentIds { get; set; }
    public ICollection<Guid> CourseIds { get; set; }
    public ICollection<Guid> StudentIds { get; set; }
    public ICollection<Guid> SubmissionIds { get; set; }
    public uint? MaxMark { get; set; }
    public DateTime DueDate { get; set; }
    public Guid? ThemeId { get; set; }
    public Guid Id { get; set; }
}