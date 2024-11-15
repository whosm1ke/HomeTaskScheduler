using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Users;

namespace HomeTaskScheduler.Application.Contracts.Persistence;

public interface IUserRepository : IGenericRepository<AbstractUser>
{
    public Task<Student?> GetStudentByIdAsync(Guid id);
    public Task<Teacher?> GetTeacherByIdAsync(Guid id);
}