using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyDemo.Core;

namespace MyDemo.Infra.Configuration
{
  public class UserConfiguration : IEntityTypeConfiguration<User>
  {
    public void Configure(EntityTypeBuilder<User> builder)
    {
      builder.HasKey(e => e.Id);
      builder.Property(e => e.UserName).IsRequired().HasMaxLength(50);
      builder.HasIndex(e => e.UserName).IsUnique();

      builder.ToTable("Users");
    }
  }
}