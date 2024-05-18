using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Shared.Config;
using Shared.Database.Entities;

namespace Shared.Database;

public class CompanyDbContext(IOptions<DataBaseOptions> options) : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<UserProjectTeam> UserProjectTeams { get; set; }
    public DbSet<Shift> Shifts { get; set; }
    public DbSet<ProjectTeamRole> ProjectTeamRoles { get; set; }
    public DbSet<ProjectTeam> ProjectTeams { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Leave> Leaves { get; set; }
    public DbSet<BasicRole> BasicRoles { get; set; }
    public DbSet<Availability> Availabilities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(options.Value.ConnectionString);
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
