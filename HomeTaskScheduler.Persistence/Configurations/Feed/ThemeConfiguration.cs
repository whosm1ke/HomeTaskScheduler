using HomeTaskScheduler.Domain.Entities.Feed;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeTaskScheduler.Persistence.Configurations.Feed;

public class ThemeConfiguration : IEntityTypeConfiguration<Theme>
{
    public void Configure(EntityTypeBuilder<Theme> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Id).ValueGeneratedOnAdd();

        builder.Property(t => t.CreatedOn)
            .HasColumnType("timestamp without time zone")
            .IsRequired();

        builder.Property(t => t.CreatedBy)
            .IsRequired();

        builder.Property(t => t.ModifiedOn)
            .HasColumnType("timestamp without time zone")
            .IsRequired();

        builder.Property(t => t.ModifiedBy)
            .IsRequired();

        builder.Property(t => t.ThemeName)
            .IsRequired()
            .HasMaxLength(200);

        builder.HasMany(t => t.Tasks)
            .WithOne(t => t.Theme)
            .HasForeignKey(t => t.ThemeId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.ToTable("Themes");
    }
}
