using ChatWeb.Api.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChatWeb.Api.Database;

public class ChatWebDbContext(DbContextOptions<ChatWebDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ChatWebDbContext).Assembly);
    }
}
