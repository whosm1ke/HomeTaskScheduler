using HomeTaskScheduler.Domain.Entities.Feed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeTaskScheduler.Persistence.Configurations.Feed;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedOnAdd();

        builder.Property(c => c.CreatedOn)
            .HasColumnType("timestamp without time zone")
            .IsRequired();

        builder.Property(c => c.CreatedBy)
            .IsRequired();

        builder.Property(c => c.ModifiedOn)
            .HasColumnType("timestamp without time zone")
            .IsRequired();

        builder.Property(c => c.ModifiedBy)
            .IsRequired();

        builder.Property(c => c.CommentPayload)
            .IsRequired()
            .HasMaxLength(2000);

        builder.Property(c => c.CommentTargetType)
            .IsRequired();

        builder.Property(c => c.AbstractTaskId)
            .IsRequired(false);

        builder.Property(c => c.CourseId)
            .IsRequired(false);

        builder.HasOne(x => x.AbstractTaskConfiguration)
            .WithMany(x => x.Comments)
            .HasForeignKey(c => c.AbstractTaskId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasOne(x => x.AbstractUser)
            .WithMany(u => u.Comments)
            .HasForeignKey(c => c.AbstractUserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Course)
            .WithMany(x => x.Comments)
            .HasForeignKey(c => c.CourseId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.ToTable("Comments");
    }
}
