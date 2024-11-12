namespace HomeTaskScheduler.Application.Contracts.Persistence;

public interface IUnitOfWork : IDisposable
{
    public IUserRepository UserRepository { get; }
    public IAttachmentRepository AttachmentRepository { get; }
    public ICommentRepository CommentRepository { get; }
    public ICourseRepository CourseRepository { get; }
    public ISubmissionRepository SubmissionRepository { get; }
    public ITaskConfigurationRepository TaskConfigurationRepository { get; }
    public IThemeRepository ThemeRepository { get; }
    Task SaveAsync();
}