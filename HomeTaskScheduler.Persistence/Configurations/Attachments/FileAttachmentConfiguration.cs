using HomeTaskScheduler.Domain.Entities.Attachments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeTaskScheduler.Persistence.Configurations.Attachments;

public class FileAttachmentConfiguration : IEntityTypeConfiguration<FileAttachment>
{
    public void Configure(EntityTypeBuilder<FileAttachment> builder)
    {
        builder.Property(x => x.Width)
            .IsRequired(false);
        
        builder.Property(x => x.Height)
            .IsRequired(false);
        
        builder.Property(x => x.Path)
            .HasMaxLength(300)
            .IsRequired();
        
        builder.Property(x => x.FileSize)
            .IsRequired();
        
        builder.Property(x => x.ContentType)
            .HasMaxLength(64)
            .IsRequired();
        
        builder.Property(x => x.Extension)
            .HasMaxLength(64)
            .IsRequired();
    }
}