using MediatR;
using Microsoft.Extensions.Logging;

namespace CafeInfoApp.UseCases.Employees.AddEmployee;
internal class AddEmployeeCommandHandler : IRequestHandler<AddEmployeeCommand>
{
    private readonly ILogger<AddEmployeeCommandHandler> _logger;

    public AddEmployeeCommandHandler(ILogger<AddEmployeeCommandHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
    {
        _logger.LogInformation("starting add employee command handler");
        return Task.CompletedTask;
    }
}
