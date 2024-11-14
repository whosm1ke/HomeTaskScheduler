namespace HomeTaskScheduler.Application.DTO.Tasks;

public class TaskConfigurationListDto
{
    public Guid Id { get; set; }
    public string TaskTittle { get; set; }
    public string TaskInstructions { get; set; }
    public DateTime DueDate { get; set; }
}