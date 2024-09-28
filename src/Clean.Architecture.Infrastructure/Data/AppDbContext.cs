using CafeInfoApp.Core.ContributorAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Clean.Architecture.Infrastructure.Data;
public class AppDbContext : DbContext
{
    public AppDbContext() {}
    // public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connString = "server=localhost;uid=root;pwd=admin;database=CafeInfo";
        var serverVersion = new MySqlServerVersion(new Version(9, 0, 1));
        optionsBuilder.UseMySql(connString, serverVersion);
    }

    public DbSet<Employee> Employees => Set<Employee>();

}
