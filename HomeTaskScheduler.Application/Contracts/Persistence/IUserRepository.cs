using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Users;

namespace HomeTaskScheduler.Application.Contracts.Persistence;

public interface IUserRepository : IGenericRepository<AbstractUser>
{
    public Student GetStudentByIdAsync(Guid id);
    public Teacher GetTeacherByIdAsync(Guid id);
}