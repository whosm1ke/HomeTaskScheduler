using HomeTaskScheduler.Application.Contracts.Persistence;
using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Attachments;
using HomeTaskScheduler.Domain.Entities.Feed;
using HomeTaskScheduler.Domain.Entities.Submissions;
using HomeTaskScheduler.Domain.Entities.Tasks;
using HomeTaskScheduler.Domain.Entities.Users;
using HomeTaskScheduler.Persistence.Specifications.AttachmentSpecifications;
using HomeTaskScheduler.Persistence.Specifications.BaseLogic;
using HomeTaskScheduler.Persistence.Specifications.CommentSpecifications;
using HomeTaskScheduler.Persistence.Specifications.CourseSpecifications;
using HomeTaskScheduler.Persistence.Specifications.SubmissionSpecifications;
using HomeTaskScheduler.Persistence.Specifications.TaskConfigurationSpecifications;
using HomeTaskScheduler.Persistence.Specifications.ThemeSpecifications;
using HomeTaskScheduler.Persistence.Specifications.UserSpecifications;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HomeTaskScheduler.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
{

    protected AppDbContext Db { get; }

    public GenericRepository(AppDbContext db)
    {
        Db = db;
    }

    public IQueryable<T> TrackedQueryable
    {
        get => Db.Set<T>();
    }
    public IQueryable<T> Queryable
    {
        get => Db.Set<T>().AsNoTracking();
    }

    public async Task<T?> GetAsync(Guid id)
    {
        return await Db.Set<T>().FindAsync(id);
    }

    public async Task<T?> GetAsyncNoTracking(Guid id)
    {
        return await Db.Set<T>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<IReadOnlyList<T>> GetAllAsync()
    {
        return await Db.Set<T>().ToListAsync();
    }

    public async Task<IReadOnlyList<T>> GetAllAsyncNoTracking()
    {
        return await Db.Set<T>().AsNoTracking().ToListAsync();
    }

    public async Task<T> AddAsync(T item)
    {
        await Db.AddAsync(item);
        return item;
    }

    public async Task<bool> ExistsAsync(Guid id)
    {
        return await Db.Set<T>().AnyAsync(x => x.Id == id);
    }

    public async Task<bool> ExistAllAsync(IEnumerable<Guid> ids)
    {
        return await Db.Set<T>().AllAsync(x => ids.Contains(x.Id));
    }


    public void Update(T item)
    {
        Db.Set<T>().Update(item);
    }

    public void UpdateRange(IEnumerable<T> items)
    {
        Db.Set<T>().UpdateRange(items);
    }

    public void Delete(T item)
    {
        Db.Set<T>().Remove(item);
    }

    public void DeleteRange(IEnumerable<T> items)
    {
        Db.Set<T>().RemoveRange(items);
    }
}

public class AttachmentRepository: GenericRepository<AbstractAttachment>, IAttachmentRepository
{
    public AttachmentRepository(AppDbContext db) : base(db){}

    public async Task<FileAttachment?> GetFileAttachmentByIdAsync(Guid id)
    {
        return await Db.Attachments.BuildQuery(new AttachmentByIdSpecification(id))
            .OfType<FileAttachment>()
            .FirstOrDefaultAsync();
    }

    public async Task<VideoAttachment?> GetVideoAttachmentByIdAsync(Guid id)
    {
        return await Db.Attachments.BuildQuery(new AttachmentByIdSpecification(id))
            .OfType<VideoAttachment>()
            .FirstOrDefaultAsync();
    }

    public async Task<LinkAttachment?> GetLinkAttachmentByIdAsync(Guid id)
    {
        return await Db.Attachments.BuildQuery(new AttachmentByIdSpecification(id))
            .OfType<LinkAttachment>()
            .FirstOrDefaultAsync();
    }
}

public class CommentRepository : GenericRepository<Comment>, ICommentRepository
{
    public CommentRepository(AppDbContext db) : base(db){}

    public async Task<Comment?> GetCommentByIdAsync(Guid id)
    {
        return await Db.Comments.BuildQuery(new CommentByIdSpecification(id))
            .FirstOrDefaultAsync();
    }

    public async Task<IReadOnlyList<Comment>> GetAllCommentsByTaskIdAsync(Guid taskId)
    {
        return await Db.Comments.BuildQuery(new CommentsByTaskIdSpecification(taskId))
            .ToListAsync();
    }

    public async Task<IReadOnlyList<Comment>> GetAllCommentsByCourseIdAsync(Guid courseId)
    {
        return await Db.Comments.BuildQuery(new CommentsByCourseIdSpecification(courseId))
            .ToListAsync();
    }
}

public class CourseRepository : GenericRepository<Course>, ICourseRepository
{
    public CourseRepository(AppDbContext db) : base(db){}

    public async Task<Course?> GetCourseByIdAsync(Guid id)
    {
        return await Db.Courses.BuildQuery(new CourseByIdSpecification(id))
            .FirstOrDefaultAsync();
    }

    public async Task<IReadOnlyList<Course>> GetAllByTeacherIdAsync(Guid teacherId)
    {
        return await Db.Courses.BuildQuery(new CourseByTeacherIdSpecification(teacherId))
            .ToListAsync();
        
    }

    public async Task<IReadOnlyList<Course>> GetAllByStudentIdAsync(Guid studentId)
    {
        return await Db.Courses.BuildQuery(new CourseByStudentIdSpecification(studentId))
            .ToListAsync();
    }
}

public class SubmissionRepository : GenericRepository<AbstractSubmission>, ISubmissionRepository
{
    public SubmissionRepository(AppDbContext db) : base(db){}
    public async Task<QuestionSubmission?> GetQuestionSubmissionByIdAsync(Guid id)
    {
        return await Db.Submissions.BuildQuery(new SubmissionByIdSpecification(id))
            .OfType<QuestionSubmission>()
            .FirstOrDefaultAsync();
    }

    public async Task<SimpleSubmission?> GetSimpleSubmissionByIdAsync(Guid id)
    {
        return await Db.Submissions.BuildQuery(new SubmissionByIdSpecification(id))
            .OfType<SimpleSubmission>()
            .FirstOrDefaultAsync();
    }

    public async Task<TestSubmission?> GetTestSubmissionByIdAsync(Guid id)
    {
        return await Db.Submissions.BuildQuery(new SubmissionByIdSpecification(id))
            .OfType<TestSubmission>()
            .FirstOrDefaultAsync();
    }

    public async Task<IReadOnlyList<AbstractSubmission>> GetAllAsync(Guid taskId)
    {
        return await Db.Submissions.BuildQuery(new SubmissionsByTaskIdSpecification(taskId))
            .ToListAsync();
    }
}

public class TaskConfigurationRepository : GenericRepository<AbstractTaskConfiguration>, ITaskConfigurationRepository
{
    public TaskConfigurationRepository(AppDbContext db) : base(db){}

    public async Task<QuestionTaskConfiguration?> GetQuestionTaskConfigurationByIdAsync(Guid id)
    {
        return await Db.TaskConfigurations.BuildQuery(new TaskByIdSpecification(id))
            .OfType<QuestionTaskConfiguration>()
            .FirstOrDefaultAsync();
    }

    public async Task<SimpleTaskConfiguration?> GetSimpleTaskConfigurationByIdAsync(Guid id)
    {
        return await Db.TaskConfigurations.BuildQuery(new TaskByIdSpecification(id))
            .OfType<SimpleTaskConfiguration>()
            .FirstOrDefaultAsync();
    }

    public async Task<TestTaskConfiguration?> GetTestTaskConfigurationByIdAsync(Guid id)
    {
        return await Db.TaskConfigurations.BuildQuery(new TaskByIdSpecification(id))
            .OfType<TestTaskConfiguration>()
            .FirstOrDefaultAsync();
    }

    public async Task<IReadOnlyList<AbstractTaskConfiguration>> GetAllAsync(Guid courseId)
    {
        return await Db.TaskConfigurations.BuildQuery(new TaskByCourseIdSpecification(courseId))
            .ToListAsync();
    }
}

public class ThemeRepository : GenericRepository<Theme>, IThemeRepository
{
    public ThemeRepository(AppDbContext db) : base(db)
    {
    }

    public async Task<Theme?> GetThemeByIdAsync(Guid id)
    {
        return await Db.Themes.BuildQuery(new ThemeByIdSpecification(id))
            .FirstOrDefaultAsync();
    }

    public async Task<IReadOnlyList<Theme>> GetAllAsync(Guid courseId)
    {
        return await Db.Themes.BuildQuery(new ThemesByCourseIdSpecification(courseId))
            .ToListAsync();
    }
}

public class UserRepository : GenericRepository<AbstractUser>, IUserRepository
{
    public UserRepository(AppDbContext db) : base(db){}

    public async Task<Student?> GetStudentByIdAsync(Guid id)
    {
        return await Db.Users
            .OfType<Student>()
            .BuildQuery(new StudentByIdSpecification(id))
            .FirstOrDefaultAsync();
    }

    public async Task<Teacher?> GetTeacherByIdAsync(Guid id)
    {
        return await Db.Users
            .OfType<Teacher>()
            .BuildQuery(new TeacherByIdSpecification(id))
            .FirstOrDefaultAsync();
    }

    public async Task<IReadOnlyList<Teacher>> GetAllTeachersAsync(Guid courseId)
    {
        return await Db.Users
            .OfType<Teacher>()
            .BuildQuery(new TeachersByCourseIdSpecification(courseId))
            .ToListAsync();
    }

    public async Task<IReadOnlyList<Student>> GetAllStudentsAsync(Guid courseId)
    {
        return await Db.Users
            .OfType<Student>()
            .BuildQuery(new StudentsByCourseIdSpecification(courseId))
            .ToListAsync();
    }
}

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context, IServiceProvider serviceProvider)
    {
        _context = context;
        UserRepository = serviceProvider.GetRequiredService<IUserRepository>();
        AttachmentRepository = serviceProvider.GetRequiredService<IAttachmentRepository>();
        CommentRepository = serviceProvider.GetRequiredService<ICommentRepository>();
        CourseRepository = serviceProvider.GetRequiredService<ICourseRepository>();
        SubmissionRepository = serviceProvider.GetRequiredService<ISubmissionRepository>();
        TaskConfigurationRepository = serviceProvider.GetRequiredService<ITaskConfigurationRepository>();
        ThemeRepository = serviceProvider.GetRequiredService<IThemeRepository>();
    }

    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }

    public IUserRepository UserRepository { get; }
    public IAttachmentRepository AttachmentRepository { get; }
    public ICommentRepository CommentRepository { get; }
    public ICourseRepository CourseRepository { get; }
    public ISubmissionRepository SubmissionRepository { get; }
    public ITaskConfigurationRepository TaskConfigurationRepository { get; }
    public IThemeRepository ThemeRepository { get; }
    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}