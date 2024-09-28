using CafeInfoApp.Web.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CafeInfoApp.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public Task AddEmployee([FromBody] AddEmployeeDto employeeDto)
    {
        _logger.LogInformation("Adding employee with Id: {id}", employeeDto.Id);
        return Task.CompletedTask;
    }
}
