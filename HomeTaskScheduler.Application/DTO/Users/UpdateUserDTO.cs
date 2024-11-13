using HomeTaskScheduler.Application.DTO.Common;

namespace HomeTaskScheduler.Application.DTO.Users;

public class UpdateUserDto: CreateUserDto, IEntity
{
    public Guid Id { get; set; }
}