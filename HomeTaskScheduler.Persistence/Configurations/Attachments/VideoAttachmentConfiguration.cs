using HomeTaskScheduler.Domain.Entities.Attachments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeTaskScheduler.Persistence.Configurations.Attachments;

public class VideoAttachmentConfiguration : IEntityTypeConfiguration<VideoAttachment>
{
    public void Configure(EntityTypeBuilder<VideoAttachment> builder)
    {
    }
}