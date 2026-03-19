using Microsoft.EntityFrameworkCore;

namespace HelloWorldApi.Data;

public class GreetingDbContext : DbContext
{
    public GreetingDbContext(DbContextOptions<GreetingDbContext> options)
        : base(options)
    {
    }

    public DbSet<GreetingRecord> Greetings => Set<GreetingRecord>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GreetingRecord>()
            .Property(g => g.CreatedAt)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
    }
}
