using MediatR;

namespace CafeInfoApp.UseCases.Employees.AddEmployee;
public record AddEmployeeCommand: IRequest
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }

    public required string Gender { get; set; }
}
