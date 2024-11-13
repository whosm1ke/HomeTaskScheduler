using HomeTaskScheduler.Application.DTO.Common;

namespace HomeTaskScheduler.Application.DTO.Tasks;

public abstract class UpdateTaskConfigurationDto : CreateTaskConfigurationDto, IEntity
{
    public Guid Id { get; set; }
}