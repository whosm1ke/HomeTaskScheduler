using HomeTaskScheduler.Domain.Common;
using HomeTaskScheduler.Domain.Entities.Users;
using HomeTaskScheduler.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeTaskScheduler.Persistence.Configurations.Users;

public class AbstractUserConfiguration : IEntityTypeConfiguration<AbstractUser>
{
    public void Configure(EntityTypeBuilder<AbstractUser> builder)
    {
        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).ValueGeneratedOnAdd();

        builder.Property(u => u.FirstName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(u => u.LastName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Ignore(u => u.FullName);

        builder.Property(u => u.AvatarUrl)
            .HasMaxLength(200);

        builder.Property(u => u.PreferedLanguage)
            .HasMaxLength(10);

        builder.Property(u => u.Username)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(u => u.LastActivity)
            .IsRequired(false);

        builder.ToTable("Users");

        builder.HasDiscriminator(x => x.UserType)
            .HasValue<Student>(UserType.Student)
            .HasValue<Teacher>(UserType.Teacher);
    }
}