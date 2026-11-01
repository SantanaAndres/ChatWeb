using ChatWeb.Api.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChatWeb.Api.Database.DbConfig;

public class UserDbConfig: IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        
        builder
            .Property(u => u.UserId)
            .HasColumnName("user_id");
        
        builder
            .Property(b => b.Email)
            .HasColumnName("user_email")
            .HasMaxLength(255)
            .IsRequired();
        
        builder
            .Property(b => b.Password)
            .HasColumnName("user_password")
            .HasMaxLength(1000)
            .IsRequired();
        
        builder.HasKey(u => u.UserId);
        
        builder.Property(u => u.UserId)
            .ValueGeneratedOnAdd();    
        
        builder.HasIndex(u => u.Email)
            .IsUnique();
        
        builder.HasIndex(u => u.UserId)
            .IsUnique();
        
    }
}
