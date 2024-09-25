using Ardalis.Result;
using MediatR;

namespace Clean.Architecture.UseCases.Contributors.Update;

public record UpdateContributorCommand(int ContributorId, string NewName) : IRequest<Result<ContributorDTO>>;
