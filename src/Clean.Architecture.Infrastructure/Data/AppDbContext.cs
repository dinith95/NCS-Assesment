using Clean.Architecture.Core.ContributorAggregate;
using Microsoft.EntityFrameworkCore;

namespace Clean.Architecture.Infrastructure.Data;
public class AppDbContext : DbContext
{

  public DbSet<Contributor> Contributors => Set<Contributor>();

}
