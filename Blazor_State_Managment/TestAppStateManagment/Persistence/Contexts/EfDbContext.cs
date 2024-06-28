using Microsoft.EntityFrameworkCore;
using TestAppStateManagment.Shared;

namespace Persistence.Contexts;

public class EfDbContext : DbContext
{
    public EfDbContext(DbContextOptions<EfDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-80LFEP2\\MSSQLMRT;Database=BigDataDb;User Id=workcube;Password=eta");
    }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("Users");
        modelBuilder.Entity<User>().HasKey(x => x.user_id);
        modelBuilder.Entity<User>().Property(x => x.full_name).HasMaxLength(50);
        modelBuilder.Entity<User>().Property(x => x.username).HasMaxLength(50);
        modelBuilder.Entity<User>().Property(x => x.email).HasMaxLength(50);
    }
}
