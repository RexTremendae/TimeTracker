using Microsoft.EntityFrameworkCore;
using TimeTracker.Entities;

namespace TimeTracker;

public class TimeTrackerDbContext : DbContext
{
    public TimeTrackerDbContext(DbContextOptions<TimeTrackerDbContext> options) : base(options)
    {
    }

    public string GetConnectionString() => base.Database.GetDbConnection().ConnectionString;

    public DbSet<ClientEntity> Clients { get; set; } = default!;
    public DbSet<ProjectEntity> Projects { get; set; } = default!;
    public DbSet<TimeEntryEntity> TimeEntries { get; set; } = default!;
}
