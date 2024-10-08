﻿using CafeInfoApp.Core.ContributorAggregate;
using CafeInfoApp.Core.Interfaces;
using Clean.Architecture.Core.ContributorAggregate;
using Clean.Architecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Clean.Architecture.Infrastructure;
public static class InfrastructureServiceExtensions
{
    public static IServiceCollection AddInfrastructureServices(
      this IServiceCollection services,
      ConfigurationManager config,
      ILogger logger)
    {
        string? connectionString = config.GetConnectionString("MySqlConnection") ?? string.Empty;

        //  services.AddScoped<IListContributorsQueryService, ListContributorsQueryService>();
        //services.AddScoped<IDeleteContributorService, DeleteContributorService>();
       
        services.AddDbContext<AppDbContext>();
        services.AddScoped<IRepository<Employee>, EfRepository<Employee>>();
        services.AddScoped<IRepository<Contributor>, EfRepository<Contributor>>();

        logger.LogInformation("{Project} services registered", "Infrastructure");

        return services;
    }
}
