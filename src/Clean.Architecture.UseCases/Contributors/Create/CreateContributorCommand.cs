using Ardalis.Result;
using MediatR;

namespace Clean.Architecture.UseCases.Contributors.Create;

public record CreateContributorCommand(string Name, string? PhoneNumber) : IRequest<Result<int>>;
