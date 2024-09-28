using System.Reflection;
using Ardalis.ListStartupServices;
using CafeInfoApp.UseCases.Employees.AddEmployee;
using Clean.Architecture.Core.ContributorAggregate;
using Clean.Architecture.Infrastructure;
using Clean.Architecture.UseCases.Contributors.Create;
using FastEndpoints;

using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
ILogger logger = factory.CreateLogger("Program");

logger.LogInformation("Starting web host");

var builder = WebApplication.CreateBuilder(args);

ConfigureMediatR();
builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


builder.Services.AddInfrastructureServices(builder.Configuration, logger);



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseDeveloperExceptionPage();
  app.UseShowAllServicesMiddleware(); // see https://github.com/ardalis/AspNetCoreStartupServices
}
else
{
  app.UseDefaultExceptionHandler(); // from FastEndpoints
  app.UseHsts();
}

app.MapDefaultControllerRoute();
    

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.Run();

void ConfigureMediatR()
{
  var mediatRAssemblies = new[]
{
  Assembly.GetAssembly(typeof(Contributor)), // Core
  Assembly.GetAssembly(typeof(CreateContributorCommand)) // UseCases
};
  builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(mediatRAssemblies!));
  //builder.Services.AddScoped(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
  //builder.Services.AddScoped<IDomainEventDispatcher, MediatRDomainEventDispatcher>();
}



// Make the implicit Program.cs class public, so integration tests can reference the correct assembly for host building
public partial class Program
{
}
