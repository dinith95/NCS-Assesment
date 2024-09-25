using Ardalis.Result;
using MediatR;

namespace Clean.Architecture.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IRequest<Result<ContributorDTO>>;
