using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Common;

public interface ICommonUserDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Language Language { get; set; }
    public string Username { get; set; }
}