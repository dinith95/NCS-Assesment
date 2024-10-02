using AutoMapper;
using CafeInfoApp.UseCases.Employees.AddEmployee;
using CafeInfoApp.Web.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CafeInfoApp.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public EmployeeController(ILogger<EmployeeController> logger, IMapper mapper, IMediator mediator)
    {
        _logger = logger;
        _mapper = mapper;
        _mediator = mediator;
    }

    [HttpPost]
    public async Task AddEmployee([FromBody] AddEmployeeDto employeeDto)
    {
        _logger.LogInformation("Adding employee with Id: {id}", employeeDto.Id);

        var addEmpCommand = _mapper.Map<AddEmployeeCommand>(employeeDto);
        await _mediator.Send(addEmpCommand);
    }
}

public class EmployeeProfile : Profile
{
    public EmployeeProfile()
    {
        CreateMap<AddEmployeeDto, AddEmployeeCommand>();
    }
}
