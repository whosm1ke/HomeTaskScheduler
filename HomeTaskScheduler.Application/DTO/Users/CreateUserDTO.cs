using HomeTaskScheduler.Application.DTO.Common;
using HomeTaskScheduler.Domain.Enums;

namespace HomeTaskScheduler.Application.DTO.Users;

public class CreateUserDto : ICommonUserDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public Language Language { get; set; }
    public string Username { get; set; }
}