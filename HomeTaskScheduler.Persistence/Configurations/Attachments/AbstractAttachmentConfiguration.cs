using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Attachments;
using HomeTaskScheduler.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeTaskScheduler.Persistence.Configurations.Attachments;

public class AbstractAttachmentConfiguration : IEntityTypeConfiguration<AbstractAttachment>
{
    public void Configure(EntityTypeBuilder<AbstractAttachment> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(s => s.Id).ValueGeneratedOnAdd();
        
        builder.Property(a => a.AttachmentName)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(a => a.CreatedOn)
            .HasColumnType("timestamp without time zone")
            .IsRequired();

        builder.Property(a => a.CreatedBy)
            .IsRequired();

        builder.Property(a => a.ModifiedOn)
            .HasColumnType("timestamp without time zone")
            .IsRequired();

        builder.Property(a => a.ModifiedBy)
            .IsRequired();

        builder.HasOne(x => x.TaskConfiguration)
            .WithMany(x => x.Attachments)
            .HasForeignKey(x => x.TaskConfigurationId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Submission)
            .WithMany(x => x.Attachments)
            .HasForeignKey(x => x.SubmissionId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasDiscriminator(x => x.AttachmentType)
            .HasValue<LinkAttachment>(AttachmentType.Link)
            .HasValue<VideoAttachment>(AttachmentType.Video)
            .HasValue<FileAttachment>(AttachmentType.File);
    }
}
