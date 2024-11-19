using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Feed;
using HomeTaskScheduler.Persistence.Configurations.Attachments;
using HomeTaskScheduler.Persistence.Configurations.Feed;
using HomeTaskScheduler.Persistence.Configurations.Submissions;
using HomeTaskScheduler.Persistence.Configurations.Tasks;
using HomeTaskScheduler.Persistence.Configurations.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace HomeTaskScheduler.Persistence;

public class AppDbContext : DbContext
{
    private readonly IHttpContextAccessor httpContextAccessor;

    public AppDbContext(DbContextOptions<AppDbContext> options, IHttpContextAccessor httpContextAccessor) : base(
        options)
    {
        this.httpContextAccessor = httpContextAccessor;
    }

    public DbSet<AbstractUser> Users { get; set; }
    public DbSet<AbstractAttachment> Attachments { get; set; }
    public DbSet<AbstractSubmission> Submissions { get; set; }
    public DbSet<AbstractTaskConfiguration> TaskConfigurations { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Theme> Themes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        modelBuilder.ApplyConfiguration(new AbstractAttachmentConfiguration());
        modelBuilder.ApplyConfiguration(new FileAttachmentConfiguration());
        modelBuilder.ApplyConfiguration(new LinkAttachmentConfiguration());
        modelBuilder.ApplyConfiguration(new VideoAttachmentConfiguration());
        modelBuilder.ApplyConfiguration(new AbstractSubmissionConfiguration());
        modelBuilder.ApplyConfiguration(new QuestionSubmissionConfiguration());
        modelBuilder.ApplyConfiguration(new TestSubmissionConfiguration());
        modelBuilder.ApplyConfiguration(new AbstractTaskConfigurationConfiguration());
        modelBuilder.ApplyConfiguration(new QuestionTaskConfigurationConfiguration());
        modelBuilder.ApplyConfiguration(new TestTaskConfigurationConfiguration());
        modelBuilder.ApplyConfiguration(new AbstractUserConfiguration());
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        modelBuilder.ApplyConfiguration(new TeacherConfiguration());
        modelBuilder.ApplyConfiguration(new CommentConfiguration());
        modelBuilder.ApplyConfiguration(new CourseConfiguration());
        modelBuilder.ApplyConfiguration(new ThemeConfiguration());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.AddInterceptors(new AuditInterceptor(httpContextAccessor));
    }
}