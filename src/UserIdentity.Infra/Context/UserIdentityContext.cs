using Microsoft.EntityFrameworkCore;
using UserIdentity.Domain.Entities;
namespace UserIdentity.Infra.Context;

public class UserIdentityContext(DbContextOptions<UserIdentityContext> options) : DbContext(options)
{
    public DbSet<UserApplication> UserApplication { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserIdentityContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}