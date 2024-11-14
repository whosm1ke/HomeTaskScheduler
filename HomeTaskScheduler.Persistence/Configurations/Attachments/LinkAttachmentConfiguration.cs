using HomeTaskScheduler.Domain.Entities.Attachments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeTaskScheduler.Persistence.Configurations.Attachments;

public class LinkAttachmentConfiguration : IEntityTypeConfiguration<LinkAttachment>
{
    public void Configure(EntityTypeBuilder<LinkAttachment> builder)
    {
        builder.Property(x => x.Url)
            .HasMaxLength(1024)
            .IsRequired();
    }
    
    
}