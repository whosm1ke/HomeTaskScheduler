using HomeTaskScheduler.Application.DTO.Common;

namespace HomeTaskScheduler.Application.DTO.Users;

public class UserListDto: IEntity
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public string AvatarUrl { get; set; }
    public string Username { get; set; }
}