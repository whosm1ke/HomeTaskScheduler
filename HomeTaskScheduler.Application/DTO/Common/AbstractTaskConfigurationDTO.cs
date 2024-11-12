using HomeTaskScheduler.Application.DTO.Feed;
using HomeTaskScheduler.Application.DTO.Users;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Common;

public abstract class AbstractTaskConfigurationDTO 
{
    public TaskType TaskType { get; set; }
    public string TaskTittle { get; set; }
    public string TaskInstructions { get; set; }
    public ICollection<AbstractAttachmentDTO> AttachmentIds { get; set; }
    public ICollection<CourseDTO> CourseIds { get; set; }
    public ICollection<StudentDTO> StudentIds { get; set; }
    public ICollection<AbstractSubmissionDTO> SubmissionIds { get; set; }
    public uint? MaxMark { get; set; }
    public DateTime DueDate { get; set; }
    public Guid? ThemeId { get; set; }
    public Guid Id { get; set; }
}