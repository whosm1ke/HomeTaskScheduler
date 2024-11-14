using HomeTaskScheduler.Application.DTO.Common;

namespace HomeTaskScheduler.Application.DTO.Tasks;

public abstract class CreateTaskConfigurationDto : ICommonTaskConfigurationDto
{
    public string TaskTittle { get; set; }
    public string TaskInstructions { get; set; }
    public ICollection<Guid>? AttachmentIds { get; set; }
    public ICollection<Guid> CourseIds { get; set; }
    public ICollection<Guid> StudentIds { get; set; }
    public uint? MaxMark { get; set; }
    public DateTime DueDate { get; set; }
    public Guid? ThemeId { get; set; }
}