namespace CafeInfoApp.Web.Dtos;

public record AddEmployeeDto
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }

    public required string Gender { get; set; }
}
